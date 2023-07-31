using System.Text;

namespace WalkPageGen
{
    public static class MarkdownGenerator
    {
        public static string CreateMarkdown(IEvent ev) {
            var sb = new StringBuilder();

            CreateFrontMatter(ev, sb);
            if (ev.Type != EventType.Walk)
            {
                CreateContent(ev, sb);
            }
            return sb.ToString();
        }

        private static void CreateFrontMatter(IEvent ev, StringBuilder sb) {
            sb.AppendLine("---");
            CreateCommonFrontMatter(ev, sb);
            if (ev.Type == EventType.Social)
            {
                CreateSocialFrontmatter(ev, sb);
            }
            else if (ev.Type == EventType.Walk)
            {
                CreateWalkFrontmatter(ev, sb);
            }
            else if (ev.Type == EventType.Weekend)
            {
                CreateWeekendFrontmatter(ev, sb);
            }
            sb.AppendLine("---");
        }

        private static void CreateCommonFrontMatter(IEvent ev, StringBuilder sb)
        {
            sb.Append("eventId: '").Append(ev.FileId).AppendLine("'");
            sb.Append("title: '").Append(EventHelper.SanitiseString(ev.Title)).AppendLine("'");
            sb.Append("eventDate: ").AppendFormat("{0:yyyy-MM-ddT00:00:00Z}", ev.EventDate).AppendLine();
            sb.Append("eventType: '").Append(ev.Type).AppendLine("'");
            sb.Append("image: '").Append(ev.Image).AppendLine("'");
        }

        private static void CreateSocialFrontmatter(IEvent ev, StringBuilder sb)
        {
            sb.Append("depart: '").Append(ev.Depart).AppendLine("'");
        }

        private static void CreateWalkFrontmatter(IEvent ev, StringBuilder sb)
        {
            sb.Append("depart: '").Append(ev.Depart).AppendLine("'");
            sb.Append("length: ").AppendLine(ev.Length.ToString());
            sb.Append("duration: ").AppendLine(ev.Duration.ToString());
            sb.Append("description: '").Append(EventHelper.SanitiseString(ev.Description)).AppendLine("'");
            sb.Append("ascent: '").Append(ev.Ascent).AppendLine("'");
            sb.Append("distanceAway: ").AppendLine(ev.DistanceAway.ToString());
            sb.Append("parkAt: '").Append(EventHelper.SanitiseString(ev.StartLocation)).AppendLine("'");
            sb.Append("threeWordAddress: '").Append(ev.ThreeWords).AppendLine("'");
            sb.Append("mapRef: '").Append(ev.StartGridRef).AppendLine("'");
            sb.Append("mapUrl: '").Append(ev.Url).AppendLine("'");
            sb.Append("mapSource: '").Append(ev.Source).AppendLine("'");
            sb.Append("area: '").Append(ev.County).AppendLine("'");
            sb.Append("terrain: '").Append(EventHelper.SanitiseString(ev.Terrain)).AppendLine("'");
            sb.Append("fuelCost: ").AppendLine(ev.FuelCost.ToString());
            sb.Append("grading: '").Append(ev.Grading).AppendLine("'");
        }

        private static void CreateWeekendFrontmatter(IEvent ev, StringBuilder sb)
        {
            sb.Append("duration: ").AppendLine(ev.Duration.ToString());
        }

        private static void CreateContent(IEvent ev, StringBuilder sb) { }
    }
}
