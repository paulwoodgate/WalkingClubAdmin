using System.Text;

namespace WalkPageGen
{
    public static class MarkdownGenerator
    {
        public static string CreateMarkdown(IEvent ev) {
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
            sb.Append("image: './images/").Append(ev.Image).AppendLine("'");
        }

        private static void CreateSocialFrontmatter(IEvent ev, StringBuilder sb)
        {
            sb.Append("depart: '").Append(ev.Depart).AppendLine("'");
        }

        private static void CreateWalkFrontmatter(IEvent ev, StringBuilder sb)
        {
            sb.Append("depart: '").Append(ev.Depart).AppendLine("'");
            sb.Append("length: ").AppendLine(ev.Length.ToString());
        }

        private static void CreateWeekendFrontmatter(IEvent ev, StringBuilder sb)
        {
            sb.Append("duration: ").AppendLine(ev.Duration.ToString());
        }

        private static void CreateSocialContent(IEvent ev, StringBuilder sb) 
        {
            sb.AppendLine($"Location: {ev.Depart}");
            sb.AppendLine();
            sb.AppendLine(ev.Description);
        }

        private static void CreateWalkContent(IEvent ev, StringBuilder sb) 
        {
            sb.AppendLine(ev.Description);
            sb.AppendLine();
            sb.AppendLine($"Length: {ev.FormattedLength}, ({ev.FormattedDuration})  ");
            sb.AppendLine($"Ascent: {ev.Ascent}  ");
            sb.AppendLine($"Grade: {ev.Grading}  ");
            sb.AppendLine($"Walk Map: <a href='{ev.Url}' target='_blank' rel='noreferrer'>OS Maps</a>  ");
            sb.AppendLine();
            sb.AppendLine($"Meet: {ev.Depart}, or 9:45am at walk start  ");
            sb.AppendLine($"Park at: {ev.StartLocation}, ({ev.ThreeWords})  ");
            sb.AppendLine($"Travel Distance: {ev.FormattedDistance}  ");
            sb.AppendLine($"Estimated Fuel Cost: {ev.FormattedCost} plus share of car park costs");
        }
    }
}
