// Ignore Spelling: Frontmatter

using System;
using System.Linq;
using Xunit;

namespace WalkPageGen.Tests
{
    public class MarkdownGeneratorTests
    {
        [Fact]
        public void FirstLineShouldBe3Dashes()
        {
            var markdown = MarkdownGenerator.CreateMarkdown(new TestEvent{ Sequence = 1, Type = EventType.Walk, EventDate = DateTime.Parse("2020-01-05")});
            var lines = markdown.Split("\r\n");
            Assert.Equal("---", lines[0]);
        }

        [Fact]
        public void FrontMatterShouldHave2DashLines()
        {
            var markdown = MarkdownGenerator.CreateMarkdown(new TestEvent { Sequence = 1, Type = EventType.Walk, EventDate = DateTime.Parse("2020-01-05") });
            var lines = markdown.Split("\r\n");

            Assert.Equal(2, lines.Count(l => l.Equals("---")));
        }

        [Fact]
        public void WalkFrontmatterItemsShouldBePopulated()
        {
            var evnt = new TestEvent
            {
                Sequence = 12,
                Type = EventType.Walk,
                EventDate = DateTime.Parse("2023-05-04"),
                Title = "Test Walk",
                Depart = "9:30 Thorpe Wood",
                Length = 10.3,
                Image = "WalkImage.jpg",
                Description = "Test Description",
                Duration = 4.5,
                Ascent = "100m (328ft)",
                DistanceAway = 99,
                StartLocation = "Pub car park",
                ThreeWords = "one.two.three",
                StartGridRef = "NH 123 456",
                Source = "OS Maps",
                Url = "https://blah.co.uk",
                Terrain = "Field-side paths",
                County = "Bedfordshire",
                FuelCost = 10.5,
                Grading = WalkGrading.Standard
            };
            var lines = MarkdownGenerator.CreateMarkdown(evnt).Split("\r\n");

            Assert.Equal("---", lines[0]);
            Assert.Contains("eventId: 'walk-2023-12'", lines);
            Assert.Contains("title: 'Test Walk'", lines);
            Assert.Contains("eventDate: 2023-05-04T00:00:00Z", lines);
            Assert.Contains("eventType: 'Walk'", lines);
            Assert.Contains("depart: '9:30 Thorpe Wood'", lines);
            Assert.Contains("length: 10.3", lines);
            Assert.Contains("image: 'WalkImage.jpg'", lines);
            Assert.Contains("description: 'Test Description'", lines);
            Assert.Contains("duration: 4.5", lines);
            Assert.Contains("ascent: '100m (328ft)'", lines);
            Assert.Contains("distanceAway: 99", lines);
            Assert.Contains("parkAt: 'Pub car park'", lines);
            Assert.Contains("threeWordAddress: 'one.two.three'", lines);
            Assert.Contains("mapRef: 'NH 123 456'", lines);
            Assert.Contains("mapUrl: 'https://blah.co.uk'", lines);
            Assert.Contains("mapSource: 'OS Maps'", lines);
            Assert.Contains("terrain: 'Field-side paths'", lines);
            Assert.Contains("fuelCost: 10.5", lines);
            Assert.Contains("grading: 'Standard'", lines);
            Assert.Contains("area: 'Bedfordshire'", lines);
            Assert.Equal("---", lines[^2]);
        }

        [Fact]
        public void SocialFrontmatterItemsShouldBePopulated()
        {
            var evnt = new TestEvent
            {
                Sequence = 12,
                Type = EventType.Social,
                EventDate = DateTime.Parse("2023-05-04"),
                Title = "Test Social",
                Depart = "9:30 Thorpe Wood",
                Length = 10.3,
                Image = "WalkImage.jpg",
                Description = "Test Description",
                Duration = 4.5,
                Ascent = "100m (328ft)",
                DistanceAway = 99,
                StartLocation = "Pub car park",
                ThreeWords = "one.two.three",
                StartGridRef = "NH 123 456",
                Source = "OS Maps",
                Url = "https://blah.co.uk",
                Terrain = "Field-side paths",
                County = "Bedfordshire",
                FuelCost = 10.5,
                Grading = WalkGrading.Standard
            };
            var lines = MarkdownGenerator.CreateMarkdown(evnt).Split("\r\n");

            Assert.Equal("---", lines[0]);
            Assert.Contains("eventId: 'social-2023-12'", lines);
            Assert.Contains("title: 'Test Social'", lines);
            Assert.Contains("eventDate: 2023-05-04T00:00:00Z", lines);
            Assert.Contains("eventType: 'Social'", lines);
            Assert.Contains("depart: '9:30 Thorpe Wood'", lines);
            Assert.Contains("image: 'WalkImage.jpg'", lines);
            Assert.Equal("---", lines[^2]);
            Assert.Equal(9, lines.Length);
        }

        [Fact]
        public void WeekendFrontmatterItemsShouldBePopulated()
        {
            var evnt = new TestEvent
            {
                Sequence = 12,
                Type = EventType.Weekend,
                EventDate = DateTime.Parse("2023-05-04"),
                Title = "Test Weekend",
                Depart = "9:30 Thorpe Wood",
                Image = "WalkImage.jpg",
                Description = "Test Description",
                Duration = 2,
                Ascent = "100m (328ft)",
                DistanceAway = 99,
                StartLocation = "Pub car park",
                ThreeWords = "one.two.three",
                StartGridRef = "NH 123 456",
                Source = "OS Maps",
                Url = "https://blah.co.uk",
                Terrain = "Field-side paths",
                County = "Bedfordshire",
                FuelCost = 10.5,
                Grading = WalkGrading.Standard
            };
            var lines = MarkdownGenerator.CreateMarkdown(evnt).Split("\r\n");

            Assert.Equal("---", lines[0]);
            Assert.Contains("eventId: 'weekend-2023-12'", lines);
            Assert.Contains("title: 'Test Weekend'", lines);
            Assert.Contains("eventDate: 2023-05-04T00:00:00Z", lines);
            Assert.Contains("eventType: 'Weekend'", lines);
            Assert.Contains("duration: 2", lines);
            Assert.Equal("---", lines[^2]);
            Assert.Equal(9, lines.Length);
        }

        [Fact]
        public void FrontmatterItemsShouldBeReplaceQuote()
        {
            var evnt = new TestEvent
            {
                Sequence = 12,
                Type = EventType.Walk,
                EventDate = DateTime.Parse("2023-05-04"),
                Title = "Paul's Title Test",
                Depart = "9:30 Thorpe Wood",
                Length = 10.3,
                Image = "WalkImage.jpg",
                Description = "A walk along Norfolk's best coast",
                Duration = 4.5,
                Ascent = "100m (328ft)",
                DistanceAway = 99,
                StartLocation = "'Pub' car park",
                ThreeWords = "one.two.three",
                StartGridRef = "NH 123 456",
                Source = "OS Maps",
                Url = "https://blah.co.uk",
                Terrain = "Field-side paths'",
                County = "Bedfordshire",
                FuelCost = 10.5,
                Grading = WalkGrading.Standard
            };
            var lines = MarkdownGenerator.CreateMarkdown(evnt).Split("\r\n");

            Assert.Equal("---", lines[0]);
            Assert.Contains("title: 'Paul`s Title Test'", lines);
            Assert.Contains("description: 'A walk along Norfolk`s best coast'", lines);
            Assert.Contains("parkAt: '`Pub` car park'", lines);
            Assert.Contains("terrain: 'Field-side paths`'", lines);
            Assert.Equal("---", lines[^2]);
        }
    }
}
