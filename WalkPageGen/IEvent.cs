using System;

namespace WalkPageGen
{
    public enum EventType { Walk, Social, Weekend}

    public interface IEvent
    {
        int Sequence { get; set; }
        DateTime EventDate { get; set; }
        EventType Type { get; set; }

        string Title { get; set; }
        string Identifier { get; }
        string FileId { get; }
        string FormattedDate { get; }
        string SortDate { get; }
        string Description { get; set; }
        string Depart { get; set; }
        string StartLocation { get; set; }
        string ThreeWords { get; set; }
        string StartGridRef { get; set; }
        string Map { get; set; }
        string NearTo { get; set; }
        int DistanceAway { get; set; }
        double Length { get; set; }
        double Duration { get; set; }
        string Source { get; set; }
        string Url { get; set; }
        string Ascent { get; set; }
        string Terrain { get; set; }
        WalkGrading Grading { get; set; }
        double FuelCost { get; set; }
        string FormattedDuration { get; }
        string MapName { get; }
        string FormattedDistance { get; }
        string FormattedLength { get; }
        string FormattedCost { get; }
        bool IsRoute { get; }
        string County { get; set; }
        string Image { get; set; }
    }
}
