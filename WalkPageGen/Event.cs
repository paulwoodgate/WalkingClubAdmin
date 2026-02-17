using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WalkPageGen
{
    public enum WalkGrading { Standard, Moderate, Strenuous };

    public class Event : IEvent
    {
        [JsonPropertyName("id")]
        public string Id => $"{EventDate.Year}-{Sequence}";
        [JsonIgnore]
        public int Sequence { get; set; }
        [JsonPropertyName("date")]
        public DateTime EventDate { get; set; }
        [JsonPropertyName("type")]
        public EventType Type { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("leave")]
        public string Depart { get; set; }
        [JsonPropertyName("leave_from")]
        public string StartLocation { get; set; }
        [JsonPropertyName("os_ref")]
        public string StartGridRef { get; set; }
        [JsonIgnore]
        public string Map { get; set; }
        [JsonPropertyName("near_to")]
        public string NearTo { get; set; }
        [JsonPropertyName("distance_away")]
        public int DistanceAway { get; set; }
        [JsonPropertyName("length")]
        public double Length { get; set; }
        [JsonPropertyName("duration")]
        public double Duration { get; set; }
        [JsonPropertyName("source")]
        public string Source { get; set; }
        [JsonPropertyName("map_url")]
        public string Url { get; set; }
        [JsonPropertyName("w3w")]
        public string ThreeWords { get; set; }
        [JsonPropertyName("ascent")]
        public string Ascent { get; set; }
        [JsonPropertyName("terrain")]
        public string Terrain { get; set; }
        [JsonPropertyName("grading")]
        public WalkGrading Grading { get; set; }
        [JsonPropertyName("fuel_cost")]
        public double FuelCost { get; set; }
        [JsonPropertyName("county")]
        public string County { get; set; }
        [JsonPropertyName("image")]
        public string Image { get; set; }
        [JsonIgnore]
        public string Identifier => $"{Type.ToString().ToLower()}-{EventDate:yyyy-MM-dd}";
        [JsonIgnore]
        public string FormattedDate => IsRoute || Duration == 0
            ? DateHelper.FormatWalkDate(EventDate)
            : DateHelper.FormatEventDates(EventDate, Duration);
        [JsonIgnore]
        public string SortDate => EventDate.ToString("yyyy-MM-dd");
        [JsonIgnore]
        public string FileId => $"{Type.ToString().ToLower()}-{EventDate.Year}-{Sequence:D2}";
        [JsonIgnore]
        public string FormattedDuration => EventHelper.FormatDuration(Duration, IsRoute);
        [JsonIgnore]
        public string MapName => string.IsNullOrEmpty(Map) ? string.Empty : $"Explorer {Map}";
        [JsonIgnore]
        public string FormattedDistance => EventHelper.FormatDistance(DistanceAway);
        [JsonIgnore]
        public string FormattedLength => EventHelper.FormatDistance(Length);
        [JsonIgnore]
        public string FormattedCost => EventHelper.FormatCost(FuelCost);
        [JsonIgnore]
        public bool IsRoute { get; }

        public Event(IList<object> values)
        {
            const int sequence = 0;
            const int eventDate = 1;
            const int type = 2;
            const int id = 3;
            const int title = 4;
            const int start = 6;
            const int county = 5;
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

            if (values.Count < 23)
            {
                throw new ArgumentException("A walk needs 23 values");
            }

            Sequence = Convert.ToInt32(values[sequence]);
            EventDate = Convert.ToDateTime(values[eventDate]);
            Type = Enum.Parse<EventType>(values[type].ToString());
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
