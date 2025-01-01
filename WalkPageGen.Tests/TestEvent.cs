using System;

namespace WalkPageGen.Tests
{
    public class TestEvent : IEvent
    {
        public int Sequence { get; set; }
        public DateTime EventDate { get; set; }
        public EventType Type { get; set; }
        public string Title { get; set; }
        public string Identifier => $"{Type.ToString().ToLower()}-{EventDate:yyyy-MM-dd}";
        public string FileId => $"{Type.ToString().ToLower()}-{EventDate.Year}-{Sequence:D2}";
        public string FormattedDate => DateHelper.FormatWalkDate(EventDate);
        public string SortDate => EventDate.ToString("yyyy-MM-dd");
        public string Description { get; set; }
        public string Depart { get; set; }
        public string StartLocation { get; set; }
        public string StartGridRef { get; set; }
        public string Map { get; set; }
        public string MapName { get; }
        public string NearTo { get; set; }
        public int DistanceAway { get; set; }
        public string FormattedDistance => EventHelper.FormatDistance(DistanceAway);
        public double Length { get; set; }
        public string FormattedLength => EventHelper.FormatDistance(Length);
        public double Duration { get; set; }
        public string FormattedDuration => EventHelper.FormatDuration(Duration, IsRoute);
        public string Source { get; set; }
        public string Url { get; set; }
        public string Ascent { get; set; }
        public string Terrain { get; set; }
        public WalkGrading Grading { get; set; }
        public double FuelCost { get; set; }
        public string FormattedCost => EventHelper.FormatCost(FuelCost);
        public string ThreeWords { get; set; }
        public bool IsRoute { get; set; } = true;
        public string County { get; set; }
        public string Image { get; set; }
        public int? Nights { get; set; }
    }
}
