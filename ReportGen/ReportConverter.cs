
using System.IO;

namespace ReportGen
{
    public class ReportConverter
    {
        private readonly ConvertOptions Options;

        public ReportConverter(ConvertOptions options)
        {
            Options = options;
        }

        public void Convert()
        {
            if (Options.ConvertFolder)
            {
                ConvertFolder();
            }
            else
            {
                ConvertFile(Options.FileName);
            }
        }

        public void ConvertFolder()
        {
            var files = Directory.GetFiles(Options.FolderPath);
            foreach (var file in files)
            {
                ConvertFile(file);
            }
        }

        public void ConvertFile(string filename)
        {
            var fileContents = File.ReadAllText(filename);
            var report = new Report(fileContents);

            var markdown = report.ToMarkDown();
            var outputFile = Path.Combine(Options.OutputPath, $"{report.Id}.md");
            File.WriteAllText(outputFile, markdown);
        }
    }
}
