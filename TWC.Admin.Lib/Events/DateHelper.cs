using System;

namespace WalkPageGen
{
    public static class DateHelper
    {
        public static string FormatWalkDate(DateTime date)
        {
            var parts = date.ToString("dddd d MMMM").Split(" ");
            return $"{parts[0]} {CalcOrdinalDay(parts[1])} {parts[2]}";
        }

        public static string FormatEventDates(DateTime start, double duration)
        {
            var startParts = start.ToString("dddd d MMMM").Split(" ");
            var finishParts = start.AddDays(duration).ToString("dddd d MMMM").Split(" ");

            var ordinalFinish = CalcOrdinalDay(finishParts[1]);

            var formattedStart = $"{startParts[0]} {CalcOrdinalDay(startParts[1])}";
            if (startParts[2] != finishParts[2])
                formattedStart += $" {startParts[2]}";

            var formattedFinish = $"{finishParts[0]} {ordinalFinish} {finishParts[2]}";
            return $"{formattedStart} to {formattedFinish}";
        }

        private static string CalcOrdinalDay(string day)
        {
            string ordinalDay;

            if (day == "1" || day == "21" || day == "31")
                ordinalDay = $"{day}st";
            else if (day == "2" || day == "22")
                ordinalDay = $"{day}nd";
            else if (day == "3" || day == "23")
                ordinalDay = $"{day}rd";
            else
                ordinalDay = $"{day}th";
            return ordinalDay;
        }
    }
}
