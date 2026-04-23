using System.Collections.Generic;
using System.IO;
using System.Linq;
using TWC.Admin.Lib.Common;
using WalkPageGen;

namespace TWC.Admin.Lib.Events
{
    public static class GeneratorController
    {
        public static void GeneratePage(Options options)
        {
            var settings = AppSettings.ReadFromFile("appsettings.json");

            List<Event> events = GetEventsFromExcel(options, settings);

            if (options.CreateJson)
            {
                CreateJsonFile(events, options);
            }
            if (options.CreateMarkdown)
            {
                CreateMarkdownFiles(events, options);
            }
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
