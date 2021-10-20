using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WalkPageGen
{
    public static class GeneratorController
    {
        public static void GeneratePage(Options options)
        {
            try
            {
                var settings = AppSettings.ReadFromFile("appsettings.json");

                List<IEvent> walks = (settings.ReadFromGoogle)
                    ? GetEventsFromGoogle(options, settings)
                    : GetEventsFromExcel(options, settings);

                if (options.GenerateHtml)
                    CreateHtmlFile(options, walks);

                if (options.GenerateJson)
                    CreateJsonFile(options, walks);
            }
            catch
            {
                throw;
            }
        }

        private static List<IEvent> GetEventsFromGoogle(Options options, AppSettings settings)
        {
            const string applicationName = "Walks Page Html Generator";
            var range = $"{options.Year}!{settings.Range}";
            var walkData = new SheetService(applicationName, settings.SheetId)
                .GetData(range);
            List<IEvent> walks = walkData.Select(w => new Event(w)).ToList<IEvent>();
            return walks;
        }

        private static List<IEvent> GetEventsFromExcel(Options options, AppSettings settings)
        {
            var walkData = new ExcelReader(settings.Workbook, options.Year.ToString())
                .ReadRangeValues(settings.Range);
            return walkData.ConvertAll(w => new Event(w))
                .OrderBy(w => w.EventDate)
                .ToList<IEvent>();
        }

        private static void CreateHtmlFile(Options options, List<IEvent> walks)
        {
            var sourceHtml = File.ReadAllText(options.HtmlSourceFile);
            var html = GenerateHtml(options.Year, walks, sourceHtml);

            File.WriteAllText(options.HtmlOutputFile, html);
        }

        private static string GenerateHtml(int year, List<IEvent> walks, string html)
        {
            var pageGen = new HtmlGenerator(walks);
            var table = pageGen.CreateShortcutTable(year);
            html = html.Replace("{ShortcutTable}", table);
            var walksTable = pageGen.CreateWalksList();
            return html.Replace("{WalksTable}", walksTable);
        }

        private static void CreateJsonFile(Options options, List<IEvent> walks)
        {
            var json = GenerateJson(walks, options.MongoDbDates);

            File.WriteAllText(options.JsonOutputFile, json);
        }

        private static string GenerateJson(List<IEvent> walks, bool useMongoDateFormat)
        {
            return JsonGenerator.CreateJson(walks, useMongoDateFormat);
        }
    }
}
