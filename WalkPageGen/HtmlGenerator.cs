using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkPageGen
{
    public class HtmlGenerator
    {
        public HtmlGenerator(List<IEvent> events)
        {
            Walks = events.Where(e => !e.Type.Equals("Social", StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public string CreateShortcutTable(int year)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<table>");

            sb.AppendLine($"<tr class=\"tr1\"><td colspan=\"{Walks.Count}\"><h2>Walks {year}</h2></td></tr>");
            CreateMonthHeadings(year, sb);
            CreateWalkShortcuts(sb);

            sb.Append("</table>");
            return sb.ToString();
        }

        public string CreateWalksList()
        {
            StringBuilder sb = new StringBuilder();
            foreach (IEvent walk in Walks)
            {
                CreateWalkPanel(walk, sb);
            }

            return sb.ToString();
        }

        private void CreateMonthHeadings(int year, StringBuilder sb)
        {
            sb.AppendLine("<tr class=\"tr7\">");

            for (int month = 1; month < 13; month++)
            {
                var monthName = DateTime.Parse($"{year}-{month}-01").ToString("MMMM");
                if (monthName.Length > 5)
                {
                    monthName = monthName.Substring(0, 3);
                }

                int numWalks = Walks.Count(w => w.EventDate.Month == month);

                sb.AppendLine($"<td colspan=\"{numWalks}\"><p>{monthName}</p></td>");
            }
            sb.AppendLine("</tr>");
        }

        private void CreateWalkShortcuts(StringBuilder sb)
        {
            sb.AppendLine("<tr class=\"tr2\">");

            foreach (IEvent walk in Walks)
            {
                sb.AppendLine($"<td><p><a href=\"#{walk.Identifier}\">{walk.EventDate.Day}</a></p></td>");
            }

            sb.AppendLine("</tr>");
        }

        private void CreateWalkPanel(IEvent walk, StringBuilder sb)
        {
            sb.AppendLine("<table>");

            sb.AppendLine($"<tr><td colspan=2 class=\"tr4\" id=\"{walk.Identifier}\">Walk {walk.Sequence}/{walk.EventDate.Year}</td></tr>");
            sb.AppendLine($"<tr><td colspan=2 class=\"tr1\">{walk.FormattedDate}</td></tr>");
            sb.AppendLine($"<tr><td colspan=2 class=\"tr1\">{walk.Title}</td></tr>");
            sb.AppendLine($"<tr><td colspan=2 class=\"tr5\">{walk.Description}</td></tr>");
            sb.AppendLine("<tr><td></td><td></td></tr>");
            sb.AppendLine($"<tr><td>Depart:</td><td>{walk.Depart}</td></tr>");
            sb.AppendLine($"<tr><td>Start/Finish:</td><td>{walk.StartLocation}</td></tr>");
            sb.AppendLine($"<tr><td>What3Words:</td><td>{walk.ThreeWords}</td></tr>");
            sb.AppendLine($"<tr><td>Grid Reference:</td><td>{walk.StartGridRef}</td></tr>");
            sb.AppendLine($"<tr><td>Near To:</td><td>{walk.NearTo}</td></tr>");
            sb.AppendLine($"<tr><td>Distance Away:</td><td>{walk.FormattedDistance}</td></tr>");
            sb.AppendLine($"<tr><td>Walk Length:</td><td>{walk.FormattedLength}</td></tr>");
            sb.AppendLine($"<tr><td>Walk Time:</td><td>{walk.FormattedDuration}</td></tr>");
            sb.AppendLine($"<tr><td>Total Ascent:</td><td>{walk.Ascent}</td></tr>");

            string publication;
            if (string.IsNullOrEmpty(walk.Url))
            {
                publication = walk.Source;
            }
            else
            {
                publication = $"<a href={walk.Url}>{walk.Source}</a>";
            }

            sb.AppendLine($"<tr><td>Publication:</td><td>{publication}</td></tr>");
            sb.AppendLine($"<tr><td>Terrain:</td><td>{walk.Terrain}</td></tr>");

            string grading = GetGradingImage(walk.Grading) + walk.Grading.ToString();
            sb.AppendLine($"<tr><td>Grading:</td><td>{grading}</td></tr>");

            sb.AppendLine($"<tr><td>Estimated Fuel Cost:</td><td>{walk.FormattedCost}</td></tr>");

            sb.AppendLine("</table>");
            sb.AppendLine("<h2><img class=\"ruler\" src=\"images/anarule.gif\" alt=\"line\"></h2>");
        }

        private string GetGradingImage(WalkGrading grading)
        {
            string image = "";
            for (int i = 0; i <= (int)grading; i++)
            {
                image += "<img src=\"images/boot.gif\" class=\"boot\" alt=\"walk\">";
            }

            return image;
        }

        private readonly List<IEvent> Walks;
    }
}