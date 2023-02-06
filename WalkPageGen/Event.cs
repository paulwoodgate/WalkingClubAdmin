using System;
using System.Collections.Generic;

namespace WalkPageGen
{
    public enum WalkGrading { Standard, Moderate, Strenuous };

    public class Event : IEvent
    {
        public int Sequence { get; set; }
        public DateTime EventDate { get; set; }
        public string Type { get; set; } = "";
        public string Title { get; set; }
        public string Description { get; set; }
        public string Depart { get; set; }
        public string StartLocation { get; set; }
        public string StartGridRef { get; set; }
        public string Map { get; set; }
        public string NearTo { get; set; }
        public int DistanceAway { get; set; }
        public double Length { get; set; }
        public int? Nights { get; set; }
        public double Duration { get; set; }
        public string Source { get; set; }
        public string Url { get; set; }
        public string ThreeWords { get; set; }
        public string Ascent { get; set; }
        public string Terrain { get; set; }
        public WalkGrading Grading { get; set; }
        public double FuelCost { get; set; }
        public string County { get; set; }
        public string Image { get; set; }
        public string Identifier => $"{Type.ToLower()}{Sequence}/{EventDate.Year}";
        public string FormattedDate => IsRoute || Duration == 0
            ? DateHelper.FormatWalkDate(EventDate)
            : DateHelper.FormatEventDates(EventDate, Duration);
        public string SortDate => EventDate.ToString("yyyy-MM-dd");
        public string FileId => $"{Type.ToLower()}-{EventDate.Year}-{Sequence:D2}";
        public string FormattedDuration
        {
            get
            {
                if (Duration == 0 || !IsRoute)
                    return string.Empty;

                var desc = $"{Math.Floor(Duration)} hours";
                var minutes = Duration % 1 * 60;
                if (minutes > 0)
                    desc += $" {minutes} minutes";

                return desc;
            }
        }

        public string MapName => string.IsNullOrEmpty(Map) ? string.Empty : $"Explorer {Map}";
        public string FormattedDistance => DistanceAway > 0 ? $"{DistanceAway} miles" : string.Empty;
        public string FormattedLength=> Length > 0 ? $"{Length} miles" : string.Empty;
        public string FormattedCost => FuelCost > 0 ? FuelCost.ToString("C2") : string.Empty;
        public bool IsRoute { get; }

        public Event(IList<object> values)
        {
            const int sequence = 0;
            const int eventDate = 1;
            const int type = 2;
            const int id = 3;
            const int title = 4;
            const int county = 5;
            const int start = 6;
            const int away = 7;
            const int length = 8;
            const int ascent = 9;
            const int url = 10;
            const int threeWords = 11;
            const int description = 12;
            const int depart = 13;
            const int map = 14;
            const int gridRef = 15;
            const int nearTo = 16;
            const int source = 17;
            const int time = 18;
            const int terrain = 19;
            const int grading = 20;
            const int fuelCost = 21;
            const int image = 22;
            const int nights = 23;

            if (values.Count < 23)
            {
                throw new ArgumentException("A walk needs 23 values");
            }

            Sequence = Convert.ToInt32(values[sequence]);
            EventDate = Convert.ToDateTime(values[eventDate]);
            Type = Convert.ToString(values[type]);
            Title = Convert.ToString(values[title]);
            StartLocation = Convert.ToString(values[start]);
            DistanceAway = int.TryParse(Convert.ToString(values[away]), out int distanceAway) ? distanceAway : 0;
            Length = double.TryParse(Convert.ToString(values[length]), out double walkLength) ? walkLength : 0;
            Ascent = Convert.ToString(values[ascent]);
            Url = Convert.ToString(values[url]);
            ThreeWords = Convert.ToString(values[threeWords]);
            Description = Convert.ToString(values[description]);
            Depart = Convert.ToString(values[depart]);
            Map = Convert.ToString(values[map]);
            StartGridRef = Convert.ToString(values[gridRef]);
            NearTo = Convert.ToString(values[nearTo]);
            Source = Convert.ToString(values[source]);
            Duration = double.TryParse(Convert.ToString(values[time]), out double duration) ? duration : 0;
            Terrain = Convert.ToString(values[terrain]);
            County = Convert.ToString(values[county]);
            Image = Convert.ToString(values[image]);

            if (Type == "Weekend")
            {
                if (values.Count < 24)
                {
                    throw new ArgumentException("You must supply the number of nights for a weekend");
                }

                Nights = int.TryParse(Convert.ToString(values[nights]), out int nightsAway) ? nightsAway : 0;
                if (Nights < 0)
                {
                    throw new ArgumentException("The number of nights must be greater than 0");
                }
            }

            ValidateGrading(Convert.ToString(values[grading]));

            FuelCost = double.TryParse(Convert.ToString(values[fuelCost]), out double cost) ? cost : 0;
            IsRoute = !string.IsNullOrEmpty(Convert.ToString(values[id])) && Duration > 1;
        }

        private void ValidateGrading(string gradingValue)
        {
            if (string.IsNullOrEmpty(gradingValue) || gradingValue == "#N/A")
            {
                Grading = WalkGrading.Standard;
            }
            else if (Enum.TryParse(gradingValue, out WalkGrading grade))
            {
                Grading = grade;
            }
            else
            {
                throw new ArgumentException($"{gradingValue} is not a valid walk grading");
            }
        }
    }
}
