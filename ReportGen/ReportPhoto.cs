using System;

namespace ReportGen
{
    public class ReportPhoto
    {
        public string Filename { get; set; }
        public string Caption { get; set; }

        public ReportPhoto(string filename, string caption)
        {
            if (string.IsNullOrWhiteSpace(filename))
            {
                throw new ArgumentException("You must supply a filename");
            }
                        
            Filename = PhotoService.StripPathFromFilename(filename);
            Caption = caption;
        }



        public string ToJson()
        {
            return $"{{\"file\": \"{Filename}\", \"caption\": \"{Caption}\"}}";
        }
    }
}
