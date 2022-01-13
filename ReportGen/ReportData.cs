using System;
using System.Collections.Generic;

namespace ReportGen
{
    public class ReportData
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string SubjectType { get; set; }
        public DateTime Date { get; set; }
        public DateTime EndDate { get; set; }
        public string Report { get; set; }
        public string ReportBy { get; set; }
        public string Rating { get; set; }
        public string CoverPhoto { get; set; }
        public string Photographer { get; set; }
        public List<ReportPhoto> Photos { get; } = new List<ReportPhoto>();

        public ReportData(List<string> filenames = null, List<string> captions = null)
        {
            if (filenames?.Count != captions?.Count)
            {
                throw new ArgumentException("You must supply the same number of captions as files");
            }

            CreatePhotoList(filenames, captions);
        }

        private void CreatePhotoList(List<string> filenames, List<string> captions)
        {
            if (filenames != null)
            {
                for (int i = 0; i < filenames.Count; i++)
                {
                    Photos.Add(new ReportPhoto(filenames[i], captions[i]));
                }
            }
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
            if (SubjectType == "Group")
            {
                if (EndDate == DateTime.MinValue)
                {
                    throw new ArgumentException("You must enter the end date of the event.");
                }
                if (EndDate > DateTime.Today || EndDate < Date)
                {
                    throw new ArgumentException("You must enter a valid end date for the event.");
                }
            }
            if (!string.IsNullOrEmpty(SubjectType) && SubjectType != "Day" && SubjectType != "Group")
            {
                throw new ArgumentException("The Subject Type must be empty, Day, or Group");
            }
            return true;
        }
    }
}
