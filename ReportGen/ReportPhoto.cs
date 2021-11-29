namespace ReportGen
{
    public class ReportPhoto
    {
        public string Filename { get; set; }
        public string Caption { get; set; }

        public ReportPhoto(string filename, string caption)
        {
            Filename = filename;
            Caption = caption;
        }

        public string ToJson()
        {
            return $"{{\"filename\": \"{Filename}\", \"caption\": \"{Caption}\"}}";
        }
    }
}
