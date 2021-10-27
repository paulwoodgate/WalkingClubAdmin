using System.Collections.Generic;
using System.Text;

namespace WalkPageGen
{
    public static class JsonGenerator
    {
        public static string CreateJson(List<IEvent> events, bool useMongoDateFormat)
        {
            var sb = new StringBuilder();
            sb.AppendLine("[");
            var needComma = false;

            foreach(var ev in events)
            {
                if (needComma)
                    sb.AppendLine(",");

                AppendEvent(ev, sb, useMongoDateFormat);

                needComma = true;
            }
            sb.AppendLine();
            sb.AppendLine("]");
            return sb.ToString();
        }

        private static void AppendEvent(IEvent ev, StringBuilder sb, bool useMongoDbFormat)
        {
            sb.AppendLine("\t{");
            sb.Append("\t\t\"type\": \"").Append(ev.Type).AppendLine("\",");
            sb.Append("\t\t\"id\": \"").Append(ev.FileId).AppendLine("\",");
            var eventDate = useMongoDbFormat ? $"{{\"$date\":\"{ev.EventDate:yyyy-MM-ddT00:00:00Z}\"}}" : $"\"{ev.EventDate:yyyy-MM-ddT00:00:00Z}\"";
            sb.Append("\t\t\"date\": ").Append(eventDate).AppendLine(",");
            sb.Append("\t\t\"title\": \"").Append(ev.Title).AppendLine("\",");
            sb.Append("\t\t\"image\": \"").Append(ev.Image).AppendLine("\",");
            sb.Append("\t\t\"description\": \"").Append(ev.Description).AppendLine("\",");
            sb.Append("\t\t\"startFrom\": \"").Append(ev.StartLocation).AppendLine("\",");
            sb.Append("\t\t\"distanceAway\": ").Append(ev.DistanceAway).AppendLine(",");
            sb.Append("\t\t\"county\": \"").Append(ev.County).AppendLine("\",");
            sb.Append("\t\t\"length\": ").Append(ev.Length.ToString("n1")).AppendLine(",");
            sb.Append("\t\t\"leave\": \"").Append(ev.Depart).AppendLine("\",");
            sb.Append("\t\t\"w3wReference\": \"").Append(ev.ThreeWords).AppendLine("\",");
            sb.Append("\t\t\"mapReference\": \"").Append(ev.StartGridRef).AppendLine("\",");
            sb.Append("\t\t\"nearTo\": \"").Append(ev.NearTo).AppendLine("\",");
            sb.Append("\t\t\"walkTime\": ").Append(ev.Duration.ToString("n1")).AppendLine(",");
            sb.Append("\t\t\"ascent\": \"").Append(ev.Ascent).AppendLine("\",");
            sb.AppendLine("\t\t\"source\": {");
            sb.Append("\t\t\t\"name\": \"").Append(ev.Source).AppendLine("\",");
            sb.Append("\t\t\t\"url\": \"").Append(ev.Url).AppendLine("\"");
            sb.AppendLine("\t\t},");
            sb.Append("\t\t\"terrain\": \"").Append(ev.Terrain).AppendLine("\",");
            sb.Append("\t\t\"grading\": \"").Append(ev.Grading).AppendLine("\",");
            sb.Append("\t\t\"fuelCost\": ").AppendLine(ev.FuelCost.ToString("n1"));
            sb.Append("\t}");
        }
    }
}
