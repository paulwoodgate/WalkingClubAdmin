﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGen
{
    public class Report
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public int Year => Date.Year;
        public string Title { get; set; }
        public string[] Text { get; set; }
        public string Author { get; set; }
        public string Rating { get; set; }
        public string CoverPhoto { get; set; }
        public string Photographer { get; set; }
        public List<string> Captions { get; set; }
        public List<ReportPhoto> Photos => GeneratePhotoList();

        public Report(ReportData data)
        {
            Id = data.Id;
            Date = data.Date;
            Title = data.Title;
            Author = data.ReportBy;
            Rating = data.Rating;
            CoverPhoto = data.CoverPhoto;
            Photographer = data.Photographer;

            if (!string.IsNullOrWhiteSpace(data.Report))
            {
                Text = data.Report.Split("\r\n");
            }

            Captions = data.Captions;
        }

        private List<ReportPhoto> GeneratePhotoList()
        {
            var photoList = new List<ReportPhoto>();

            for (var i = 0; i< Captions.Count; i++)
            {
                photoList.Add(new ReportPhoto($"{Id}~{i+1}.jpg", Captions[i] ));
            }

            return photoList;
        }

        public string ToJson()
        {
            var sb = new StringBuilder();
            sb.AppendLine("[{");
            sb.Append("\t\"Id\": \"").Append(Id).AppendLine("\",");
            sb.Append("\t\"Date\": ").Append("{\"$date\":\"").AppendFormat("{0:yyyy-MM-ddT00:00:00Z}", Date).Append("\"}").AppendLine(",");
            sb.Append("\t\"Year\": ").Append(Year).AppendLine(",");
            sb.Append("\t\"Title\": \"").Append(Title).AppendLine("\",");
            sb.Append("\t\"Report\": [\"").AppendJoin("\",\"", Text).AppendLine("\"],");
            sb.Append("\t\"ReportBy\": \"").Append(Author).AppendLine("\",");
            sb.Append("\t\"Rating\": \"").Append(Rating).AppendLine("\",");
            sb.Append("\t\"CoverPhoto\": \"").Append(CoverPhoto).AppendLine("\",");
            sb.Append("\t\"Photographer\": \"").Append(Photographer).AppendLine("\",");
            sb.Append("\t\"Photos\": [").AppendJoin(", ", Photos.Select(p => p.ToJson())).AppendLine("]");
            sb.AppendLine("}]");
            return sb.ToString();
        }
    }
}