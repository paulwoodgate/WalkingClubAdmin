using System;

namespace WalkPageGen
{
    public static class EventHelper
    {
        public static string FormatDuration(double duration, bool isRoute)
        {
            if (duration == 0 || !isRoute)
                return string.Empty;

            var desc = $"{Math.Floor(duration)} hours";
            var minutes = duration % 1 * 60;
            if (minutes > 0)
                desc += $" {minutes} minutes";

            return desc;
        }

        public static string FormatDistance(double distance) => distance > 0 ? $"{distance} miles" : string.Empty;

        public static string FormatCost(double cost) => cost > 0 ? cost.ToString("C2") : string.Empty;

        public static string SanitiseString(string str) => str?.Replace("'", "`");
    }
}
