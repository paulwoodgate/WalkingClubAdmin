using System;
using System.IO;
using System.Text.Json;

namespace WalkPageGen
{
    public class Options
    {
        private const string defaultFilename = "usersettings.json";
        private static readonly string appFolder = Directory.GetCurrentDirectory();

        public int Year { get; set; }
        public string ExcelSourceFile { get; set; }
        public string OutputFile { get; set; }
        public bool ReadFromGoogle { get; set; }
        public bool MongoDbDates { get; set; }
        public bool CreateJson { get; set; }
        public bool CreateMarkdown { get; set; }
        public string MarkdownFolder { get; set; }

        public Options()
        {
            Year = DateTime.Now.Year + 1;
            ReadFromGoogle = true;
            ExcelSourceFile = "source.xlsx";
            OutputFile = $"walks{Year}.json";
            CreateJson = true;
            CreateMarkdown = false;
        }

        public void Validate()
        {
            ValidateYear();
            if (!ReadFromGoogle)
            {
                ValidateExcelOptions();
            }
            ValidateOutputOptions();
        }

        private void ValidateYear()
        {
            if (Year < 2000)
            {
                throw new ArgumentException("The year must not be before 2000");
            }

            var maxYear = DateTime.Now.Year + 5;
            if (Year > maxYear)
            {
                throw new ArgumentException($"The year must not be after {maxYear}");
            }
        }


        private void ValidateExcelOptions()
        {
            if (string.IsNullOrWhiteSpace(ExcelSourceFile))
            {
                throw new ArgumentException("You must supply the location of the Excel source file");
            }

            if (!File.Exists(ExcelSourceFile))
            {
                throw new ArgumentException("The Excel source file does not exist");
            }
        }

        private void ValidateOutputOptions()
        {
            if (CreateJson)
            {
                ValidateJsonOptions();
            }
            if (CreateMarkdown)
            {
                ValidateMarkdownOptions();
            }
        }

        private void ValidateJsonOptions()
        {
            var jsonFolderPath = Path.GetDirectoryName(OutputFile);
            if (!Directory.Exists(jsonFolderPath))
            {
                throw new ArgumentException($"The folder \"{jsonFolderPath}\" does not exist");
            }
        }

        private void ValidateMarkdownOptions()
        {
            if (!Directory.Exists(MarkdownFolder))
            {
                throw new ArgumentException($"The folder \"{MarkdownFolder}\" does not exist");
            }
        }

        public void Save(string filename = "")
        {
            filename = ConstructFilePath(filename);

            var jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filename, jsonString);
        }

        public static Options Read(string filename = "")
        {
            string path = ConstructFilePath(filename);
            if (!File.Exists(path))
            {
                return new Options();
            }

            var jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Options>(jsonString);
        }

        private static string ConstructFilePath(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename))
            {
                filename = defaultFilename;
            }

            return Path.Combine(appFolder, filename);
        }
    }
}
