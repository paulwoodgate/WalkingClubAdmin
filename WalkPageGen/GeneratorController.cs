using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WalkPageGen
{
    public static class GeneratorController
    {
        public static void GeneratePage(Options options)
        {
            var settings = AppSettings.ReadFromFile("appsettings.json");

            List<Event> events = (options.ReadFromGoogle)
                ? GetEventsFromGoogle(options, settings)
                : GetEventsFromExcel(options, settings);

            if (options.CreateJson)
            {
                CreateJsonFile(events, options);
            }
            if (options.CreateMarkdown)
            {
                CreateMarkdownFiles(events, options);
            }
        }

        private static List<Event> GetEventsFromGoogle(Options options, AppSettings settings)
        {
            const string applicationName = "Walks Page Html Generator";
            var range = $"{options.Year}!{settings.Range}";
            var walkData = new SheetService(applicationName, settings.SheetId)
                .GetData(range);
            List<Event> walks = walkData.Select(w => new Event(w)).ToList<Event>();
            return walks;
        }

        private static List<Event> GetEventsFromExcel(Options options, AppSettings settings)
        {
            var walkData = new ExcelReader(settings.Workbook, options.Year.ToString())
                .ReadRangeValues(settings.Range);
            return walkData
                .ConvertAll(w => new Event(w))
                .OrderBy(w => w.EventDate)
                .ToList<Event>();
        }

        private static void CreateJsonFile(List<Event> walks, Options options)
        {
            var json = JsonGenerator.CreateJson(walks, options.MongoDbDates, options.FlattenSource);

            File.WriteAllText(options.OutputFile, json);
        }

        private static void CreateMarkdownFiles(List<Event> events, Options options)
        {
            foreach (var ev in events)
            {
                var markdown = MarkdownGenerator.CreateMarkdown(ev);
                File.WriteAllText(Path.Combine(options.MarkdownFolder, ev.FileId + ".md"), markdown);
            }
        }
    }
}
