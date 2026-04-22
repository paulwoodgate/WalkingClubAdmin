using System.Diagnostics;
using System.Text;

namespace WalkPageGen
{
    public static class MarkdownGenerator
    {
        public static string CreateMarkdown(Event ev) {
            var sb = new StringBuilder();

            CreateFrontMatter(ev, sb);
            if (ev.Type == EventType.Walk)
            {
                CreateWalkContent(ev, sb);
            }
            else if (ev.Type == EventType.Social)
            {
                CreateSocialContent(ev, sb);
            }
            return sb.ToString();
        }

        private static void CreateFrontMatter(Event ev, StringBuilder sb) {
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

        private static void CreateCommonFrontMatter(Event ev, StringBuilder sb)
        {
            sb.Append("eventId: '").Append(ev.FileId).AppendLine("'");
            sb.Append("title: '").Append(EventHelper.SanitiseString(ev.Title)).AppendLine("'");
            sb.Append("eventDate: ").AppendFormat("{0:yyyy-MM-ddT00:00:00Z}", ev.EventDate).AppendLine();
            sb.Append("eventType: '").Append(ev.Type).AppendLine("'");
            sb.Append("image: './images/").Append(ev.Image).AppendLine("'");
        }

        private static void CreateSocialFrontmatter(Event ev, StringBuilder sb)
        {
            sb.Append("depart: '").Append(ev.Depart).AppendLine("'");
        }

        private static void CreateWalkFrontmatter(Event ev, StringBuilder sb)
        {
            sb.Append("depart: '").Append(ev.Depart).AppendLine("'");
            sb.Append("length: ").AppendLine(ev.Length.ToString());
        }

        private static void CreateWeekendFrontmatter(Event ev, StringBuilder sb)
        {
            sb.Append("duration: ").AppendLine(ev.Duration.ToString());
        }

        private static void CreateSocialContent(Event ev, StringBuilder sb) 
        {
            sb.AppendLine($"Location: {ev.Depart}");
            sb.AppendLine();
            sb.AppendLine(ev.Description);
        }

        private static void CreateWalkContent(Event ev, StringBuilder sb) 
        {
            var source = ev.Source == "From Map" ? "OS Maps" : ev.Source;
            sb.AppendLine(ev.Description);
            sb.AppendLine();
            sb.AppendLine($"Length: {ev.FormattedLength}, ({ev.FormattedDuration})  ");
            sb.AppendLine($"Ascent: {ev.Ascent}  ");
            sb.AppendLine($"Terrain: {ev.Terrain}  ");
            sb.AppendLine($"Grade: {ev.Grading}  ");
            sb.AppendLine($"Walk Map: <a href='{ev.Url}' target='_blank' rel='noreferrer'>{source}</a>  ");
            sb.AppendLine();
            sb.AppendLine($"Meet: {ev.Depart}, or 9:45am at walk start  ");
            sb.AppendLine($"Park at: {ev.StartLocation}, ({ev.ThreeWords})  ");
            sb.AppendLine($"Travel Distance: {ev.FormattedDistance}  ");
            sb.AppendLine($"Estimated Fuel Cost: {ev.FormattedCost} plus share of car park costs");
        }
    }
}
