namespace ReportGen
{
    public static class PhotoService
    {
        public static string StripPathFromFilename(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename))
            {
                return filename;
            }

            var index = filename.LastIndexOf("/");

            if (index == -1)
            {
                return filename;
            }

            return filename.Substring(index + 1);
        }
    }
}
