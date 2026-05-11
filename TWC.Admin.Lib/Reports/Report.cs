using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TWC.Admin.Lib.Reports
{
    public class Report
    {
        private const string DateFormat = "{0:yyyy-MM-ddT00:00:00Z}";

        public string Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime? EndDate { get; set; }
        public int Year => Date.Year;
        public string Title { get; set; }
        public string SubjectType { get; set; }
        public string ReportType
        {
            get
            {
                return SubjectType switch
                {
                    "Group" => "Group",
                    "Day" => "Child",
                    _ => "Single",
                };
            }
        }
        public string Parent { get; set; }
        public string[] Text { get; set; }
        public string Author { get; set; }
        public string Rating { get; set; }
        public string CoverPhoto { get; set; }
        public List<PhotoList> PhotoSets {get;set;}

        public Report(ReportData data)
        {
            Id = data.Id;
            Date = data.Date;
            EndDate = data.EndDate;
            Title = data.Title;
            SubjectType = data.SubjectType;
            Author = data.ReportBy;
            Rating = data.Rating;
            CoverPhoto = PhotoService.StripPathFromFilename(data.CoverPhoto);

            if (data.SubjectType == "Day")
            {
                Parent = data.Parent;
            }
            if (!string.IsNullOrWhiteSpace(data.Report))
            {
                Text = data.Report.Split("\r\n").Where(t => t.Length > 0).ToArray();
            }

            PhotoSets = data.PhotoSets;
        }

        public Report(string json)
        {
            Id = JsonHelper.FindString("\"id\"", json);
            Date = JsonHelper.FindDate("\"date\"", json).GetValueOrDefault();
            EndDate = JsonHelper.FindDate("\"endDate\"", json);
            Title = JsonHelper.FindString("\"title\"", json);
            SubjectType = JsonHelper.FindString("\"subjectType\"", json);
            if (SubjectType == "Day")
            {
                Parent = Id[..Id.LastIndexOf('-')];
            }
            Text = JsonHelper.FindArray("\"report\"", json);
            Author = JsonHelper.FindString("\"reportBy\"", json);
            Rating = JsonHelper.FindString("\"walkRating\"", json);
            CoverPhoto = JsonHelper.FindString("\"coverPhoto\"", json);
            PhotoSets = JsonHelper.CreatePhotoSets(json);
        }

        private string GetId(string format)
        {
            if (SubjectType == "Group" || (SubjectType == "Day" && format == "Json"))
            {
                return Id;
            } else {
                return $"{Date:yyyyMMdd}";
            }
        }

        public string ToJson()
        {

            var sb = new StringBuilder();
            sb.AppendLine("[{");
            sb.Append("\t\"id\": \"").Append(GetId("Json")).AppendLine("\",");
            sb.Append("\t\"date\": ").Append("{\"$date\":\"").AppendFormat(DateFormat, Date).Append("\"}").AppendLine(",");
            if (SubjectType == "Group")
            {
                sb.Append("\t\"endDate\": ").Append("{\"$date\":\"").AppendFormat(DateFormat, EndDate).Append("\"}").AppendLine(",");
            }
            sb.Append("\t\"year\": \"").Append(Year).AppendLine("\",");
            sb.Append("\t\"title\": \"").Append(Title).AppendLine("\",");
            if (!string.IsNullOrEmpty(SubjectType))
            {
                sb.Append("\t\"subjectType\": \"").Append(SubjectType).AppendLine("\",");
            }
            if (Text?.Length > 0)
            {
                var lines = Text.Select(t => t.Replace("\"", "\\\"")).ToArray();
                sb.Append("\t\"report\": [\"").AppendJoin("\",\"", lines).AppendLine("\"],");
            }
            if (SubjectType != "Group")
            {
                sb.Append("\t\"reportBy\": \"").Append(Author).AppendLine("\",");
                sb.Append("\t\"walkRating\": \"").Append(Rating).AppendLine("\",");
            }
            sb.Append("\t\"coverPhoto\": \"").Append(CoverPhoto).AppendLine($"\"{(PhotoSets?.Count > 0 ? "," : "")}");
            if (SubjectType != "Group" && PhotoSets?.Count > 0)
            {
                sb.Append("\t\"photoSets\": [").AppendJoin(", ", PhotoSets?.Select(p => p.ToJson())).AppendLine("]");
            }
            sb.AppendLine("}]");

            return sb.ToString();
        }

        public string ToMarkDown(string imagePath)
        {
            var sb = new StringBuilder();

            CreateFrontmatter(sb, imagePath);
            CreateBody(sb, imagePath);
            return sb.ToString();
        }

        private void CreateFrontmatter(StringBuilder sb, string imagePath)
        {
            sb.AppendLine("---");
            sb.Append("reportId: \"").Append(GetId("Md")).AppendLine("\"");
            sb.Append("reportType: \"").Append(ReportType).AppendLine("\"");
            if (ReportType == "Child")
            {
                sb.Append("parent: \"").Append(Parent).AppendLine("\"");
            }
            sb.Append("title: \"").Append(Title).AppendLine("\"");
            sb.Append("reportDate: ").AppendFormat(DateFormat, Date).AppendLine();
            if (ReportType == "Group")
            {
                sb.Append("endDate: ").AppendFormat(DateFormat, EndDate).AppendLine();
            }
            sb.Append("year: ").Append(Year).AppendLine();
            sb.AppendFormat("coverPhoto: \"{0}/Photos/{1}/{2}\"", imagePath, Year, CoverPhoto).AppendLine();
            sb.AppendLine("---");
        }

        private void CreateBody(StringBuilder sb, string imagePath)
        {
            if (Text?.Length > 0)
            {
                foreach (var para in Text)
                {
                    sb.AppendLine(para);
                    sb.AppendLine();
                }
            }

            if (ReportType != "Group")
            {
                sb.Append("**Report by:** ").Append(Author).AppendLine("   ");
                sb.Append("**Walk Rating:** ").Append(Rating).AppendLine("   ");
            }

            if (PhotoSets?.Count > 0)
            {
                sb.AppendLine();
                sb.AppendLine("<center>");
                sb.AppendLine();

                foreach (var photoset in PhotoSets)
                {
                    CreatePhotoSet(photoset, sb, imagePath);
                }

                sb.AppendLine("</center>");
                sb.AppendLine();
            }
        }

        private void CreatePhotoSet(PhotoList list, StringBuilder sb, string imagePath)
        {
            foreach (var photo in list.Photos)
            {
                CreatePhoto(photo, list.Photographer, sb, imagePath);
            }
        }

        private void CreatePhoto(ReportPhoto photo, string photographer, StringBuilder sb, string imagePath)
        {
            sb.AppendFormat("![{0}]({1}/Photos/{2}/{3})", string.IsNullOrWhiteSpace(photo.Caption) ? "Unknown photo" : photo.Caption, imagePath, Year, photo.Filename).AppendLine();
            if (!string.IsNullOrWhiteSpace(photo.Caption))
            {
                sb.Append(photo.Caption).AppendLine("  ");
            }
            sb.AppendFormat("<sup>Photo by {0}</sup>", photographer).AppendLine();
            sb.AppendLine();
        }
    }
}
