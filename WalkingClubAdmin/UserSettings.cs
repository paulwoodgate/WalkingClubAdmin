using System;
using System.IO;
using System.Text.Json;

namespace WalkingClubAdmin
{
    public class UserSettings
    {
        public bool CreateHtml { get; set; }
        public bool CreateJson { get; set; }
        public string HtmlOutputFile { get; set; }
        public string HtmlSourceFile { get; set; }
        public string JsonOutputFile { get; set; }
        public int Year { get; set; }

        public UserSettings()
        {
            Year = DateTime.Now.Year + 1;
            CreateHtml = true;
            CreateJson = true;
            HtmlSourceFile = "source.html";
            HtmlOutputFile = $"walks{Year}.htnl";
            JsonOutputFile = $"walks{Year}.json";
        }
        public void Save(string filename)
        {
            var jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(filename, jsonString);
        }

        public static UserSettings Read(string filename)
        {
            if (!File.Exists(filename))
            {
                return new UserSettings();
            }

            var jsonString = File.ReadAllText(filename);
            return JsonSerializer.Deserialize<UserSettings>(jsonString);
        }
    }
}
