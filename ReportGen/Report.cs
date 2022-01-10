using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReportGen
{
    public class Report
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public int Year => Date.Year;
        public string Title { get; set; }
        public string SubjectType { get; set; }
        public string[] Text { get; set; }
        public string Author { get; set; }
        public string Rating { get; set; }
        public string CoverPhoto { get; set; }
        public string Photographer { get; set; }
        public List<ReportPhoto> Photos {get;set;}

        public Report(ReportData data)
        {
            Id = data.Id;
            Date = data.Date;
            Title = data.Title;
            SubjectType = data.SubjectType;
            Author = data.ReportBy;
            Rating = data.Rating;
            CoverPhoto = PhotoService.StripPathFromFilename(data.CoverPhoto);
            Photographer = data.Photographer;

            if (!string.IsNullOrWhiteSpace(data.Report))
            {
                Text = data.Report.Split("\r\n").Where(t => t.Length > 0).ToArray();
            }

            Photos = data.Photos;
        }

        public string ToJson()
        {
            var sb = new StringBuilder();
            sb.AppendLine("[{");
            sb.Append("\t\"id\": \"").Append(Id).AppendLine("\",");
            sb.Append("\t\"date\": ").Append("{\"$date\":\"").AppendFormat("{0:yyyy-MM-ddT00:00:00Z}", Date).Append("\"}").AppendLine(",");
            sb.Append("\t\"year\": \"").Append(Year).AppendLine("\",");
            sb.Append("\t\"title\": \"").Append(Title).AppendLine("\",");
            if (!string.IsNullOrEmpty(SubjectType))
            {
                sb.Append("\t\"subjectType\": \"").Append(SubjectType).AppendLine("\",");
            }
            if (Text?.Length > 0)
            {
                sb.Append("\t\"report\": [\"").AppendJoin("\",\"", Text).AppendLine("\"],");
            }
            sb.Append("\t\"reportBy\": \"").Append(Author).AppendLine("\",");
            sb.Append("\t\"walkRating\": \"").Append(Rating).AppendLine("\",");
            sb.Append("\t\"coverPhoto\": \"").Append(CoverPhoto).AppendLine("\",");
            sb.Append("\t\"photographer\": \"").Append(Photographer).AppendLine("\",");
            if (Photos?.Count > 0)
            {
                sb.Append("\t\"photos\": [").AppendJoin(", ", Photos.Select(p => p.ToJson())).AppendLine("]");
            }
            sb.AppendLine("}]");
            return sb.ToString();
        }
    }
}
