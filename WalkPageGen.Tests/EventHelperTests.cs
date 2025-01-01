using Xunit;

namespace WalkPageGen.Tests
{
    public class EventHelperTests
    {
        [Fact]
        public void FormatDurationShouldReturnEmptyStringIfNotRoute()
        {
            var duration = EventHelper.FormatDuration(12.2, false);

            Assert.Empty(duration);
        }

        [Fact]
        public void FormatDurationShouldReturnEmptyStringIf0Duration()
        {
            var duration = EventHelper.FormatDuration(0, true);

            Assert.Empty(duration);
        }

        [Fact]
        public void FormatDurationShouldReturnHours()
        {
            var duration = EventHelper.FormatDuration(2, true);

            Assert.Equal("2 hours", duration);
        }

        [Fact]
        public void FormatDurationShouldReturnHoursAndMinutes()
        {
            var duration = EventHelper.FormatDuration(2.5, true);

            Assert.Equal("2 hours 30 minutes", duration);
        }

        [Fact]
        public void FormatDistanceShouldReturnEmptyStringIf0Distance()
        {
            var distance = EventHelper.FormatDistance(0);

            Assert.Empty(distance);
        }

        [Fact]
        public void FormatDistanceShouldReturnMiles()
        {
            var distance = EventHelper.FormatDistance(12.2);

            Assert.Equal("12.2 miles", distance);
        }

        [Fact]
        public void FormatCostShouldReturnEmptyStringIf0Distance()
        {
            var cost = EventHelper.FormatCost(0);

            Assert.Empty(cost);
        }

        [Fact]
        public void FormatCostShouldReturnPounds()
        {
            var cost = EventHelper.FormatCost(12.2);

            Assert.Equal("£12.20", cost);
        }

        [Fact]
        public void SanitiseStringShouldRemoveSingleQuotes()
        {
            var original = "Norfolk's coasts";
            var expected = "Norfolk`s coasts";

            var changed = EventHelper.SanitiseString(original);

            Assert.Equal(expected, changed);
        }

        [Fact]
        public void SanitiseStringShouldReturnNullIfPassedNull()
        {
            string returned = EventHelper.SanitiseString(null);

            Assert.Null(returned);
        }
    }
}
