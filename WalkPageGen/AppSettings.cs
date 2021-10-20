using Microsoft.Extensions.Configuration;
using System.IO;

namespace WalkPageGen
{
    public class AppSettings
    {
        public string Range { get; set; }
        public string SheetId { get; set; }
        public string Workbook { get; set; }
        public bool ReadFromGoogle { get; set; }

        public static AppSettings ReadFromFile(string filename)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(filename, optional: true, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            var settings = new AppSettings
            {
                Range = configuration.GetSection("Range").Value,
                SheetId = configuration.GetSection("SheetId").Value,
                Workbook = configuration.GetSection("Workbook").Value,
                ReadFromGoogle = bool.Parse(configuration.GetSection("ReadFromGoogle").Value)
            };
            return settings;
        }
    }
}