using System;
using System.Collections.Generic;

namespace ReportGen
{
    public class ReportData
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Report { get; set; }
        public string ReportBy { get; set; }
        public string Rating { get; set; }
        public string CoverPhoto { get; set; }
        public string Photographer { get; set; }
        public List<string> Captions { get; set; }

        public ReportData()
        {
            Captions = new List<string>();
        }

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(Id))
            {
                throw new ArgumentException("You must enter an ID for the report.");
            }
            if (string.IsNullOrWhiteSpace(Title))
            {
                throw new ArgumentException("You must enter the title of the event.");
            }
            if (Date == DateTime.MinValue)
            {
                throw new ArgumentException("You must enter the date of the event.");
            }
            if (Date > DateTime.Today || Date < new DateTime(2000, 1, 1))
            {
                throw new ArgumentException("You must enter a valid date for the event.");
            }
            return true;
        }
    }
}
