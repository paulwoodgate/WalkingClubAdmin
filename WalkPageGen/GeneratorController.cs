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

            List<IEvent> events = (options.ReadFromGoogle)
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
            return walkData.Where(w => !string.IsNullOrEmpty((string)w[2])).ToList()
                .ConvertAll(w => new Event(w))
                .OrderBy(w => w.EventDate)
                .ToList<IEvent>();
        }

        private static void CreateJsonFile(List<IEvent> walks, Options options)
        {
            var json = JsonGenerator.CreateJson(walks, options.MongoDbDates);

            File.WriteAllText(options.OutputFile, json);
        }

        private static void CreateMarkdownFiles(List<IEvent> events, Options options)
        {
            foreach (var ev in events)
            {
                var markdown = MarkdownGenerator.CreateMarkdown(ev);
                File.WriteAllText(Path.Combine(options.MarkdownFolder, ev.FileId + ".md"), markdown);
            }
        }
    }
}
