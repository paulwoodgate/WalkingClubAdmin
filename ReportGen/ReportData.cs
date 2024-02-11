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
        public string Parent { get; set; }
        public string Report { get; set; }
        public string ReportBy { get; set; }
        public string Rating { get; set; }
        public string CoverPhoto { get; set; }
        public string Photographer { get; set; }
        public List<PhotoList> PhotoSets { get; } = new List<PhotoList>();

        public ReportData(List<string> photographers = null, List<string> filenames = null, List<string> captions = null)
        {
            if (filenames?.Count != captions?.Count || photographers?.Count != filenames?.Count)
            {
                throw new ArgumentException("You must supply the same number of photographers and captions as files");
            }

            CreatePhotoList(photographers, filenames, captions);
        }

        private void CreatePhotoList(List<string> photographers, List<string> filenames, List<string> captions)
        {
            if (filenames != null)
            {
                PhotoList photos = new PhotoList();
                for (int i = 0; i < filenames.Count; i++)
                {
                    if (!string.IsNullOrWhiteSpace(photographers[i]))
                    {
                        photos = new PhotoList();
                        PhotoSets.Add(photos);
                        photos.Photographer = photographers[i];
                    }
                    photos.Photos.Add(new ReportPhoto(filenames[i], captions[i]));
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
            if (Date > DateTime.Today || Date < new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Local))
            {
                throw new ArgumentException("You must enter a valid date for the event.");
            }
            if (SubjectType == "Group")
            {
                ValidateGroupOptions();
            }
            if (!string.IsNullOrEmpty(SubjectType) && SubjectType != "Day" && SubjectType != "Group" && SubjectType != "Walk")
            {
                throw new ArgumentException("The Subject Type must be empty, Day, Group, or Walk");
            }
            if (SubjectType == "Day" && string.IsNullOrWhiteSpace(Parent))
            {
                throw new ArgumentException("You must enter a Parent event");
            }
            return true;
        }

        private void ValidateGroupOptions()
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
    }
}
