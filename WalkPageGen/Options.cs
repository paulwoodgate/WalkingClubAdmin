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
        public string HtmlSourceFile { get; set; }
        public string HtmlOutputFile { get; set; }
        public string JsonOutputFile { get; set; }
        public bool GenerateHtml { get; set; }
        public bool GenerateJson { get; set; }
        public bool MongoDbDates { get; set; }

        public Options()
        {
            Year = DateTime.Now.Year + 1;
            GenerateHtml = true;
            GenerateJson = true;
            HtmlSourceFile = "source.html";
            HtmlOutputFile = $"walks{Year}.html";
            JsonOutputFile = $"walks{Year}.json";
        }

        public void Validate()
        {
            ValidateYear();
            ValidateCheckboxes();
            if (GenerateHtml)
            {
                ValidateHtmlOptions();
            }

            if (GenerateJson)
            {
                ValidateJsonOptions();
            }
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

        private void ValidateCheckboxes()
        {
            if (!(GenerateHtml || GenerateJson))
            {
                throw new ArgumentException("At least one checkbox should be checked");
            }
        }

        private void ValidateHtmlOptions()
        {
            if (string.IsNullOrWhiteSpace(HtmlSourceFile))
            {
                throw new ArgumentException("You must supply the location of the HTML source file");
            }

            if (!File.Exists(HtmlSourceFile))
            {
                throw new ArgumentException("The HTML source file does not exist");
            }

            if (string.IsNullOrWhiteSpace(HtmlOutputFile))
            {
                throw new ArgumentException("You must supply the name of the HTML output file");
            }

            var folderPath = Path.GetDirectoryName(HtmlOutputFile);
            if (!Directory.Exists(folderPath))
            {
                throw new ArgumentException($"The folder \"{folderPath}\" does not exist");
            }
        }

        private void ValidateJsonOptions()
        {
            var folderPath = Path.GetDirectoryName(JsonOutputFile);
            if (!Directory.Exists(folderPath))
            {
                throw new ArgumentException($"The folder \"{folderPath}\" does not exist");
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
