// Ignore Spelling: Frontmatter

using System;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using Xunit;

namespace WalkPageGen.Tests
{
    public class MarkdownGeneratorTests
    {
        [Fact]
        public void FirstLineShouldBe3Dashes()
        {
            var markdown = MarkdownGenerator.CreateMarkdown(new TestEvent{ Sequence = 1, Type = EventType.Walk, EventDate = DateTime.Parse("2020-01-05", CultureInfo.CurrentCulture.DateTimeFormat) });
            var lines = markdown.Split("\r\n");
            Assert.Equal("---", lines[0]);
        }

        [Fact]
        public void FrontMatterShouldHave2DashLines()
        {
            var markdown = MarkdownGenerator.CreateMarkdown(new TestEvent { Sequence = 1, Type = EventType.Walk, EventDate = DateTime.Parse("2020-01-05", CultureInfo.CurrentCulture.DateTimeFormat) });
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
                EventDate = DateTime.Parse("2023-05-04", CultureInfo.CurrentCulture.DateTimeFormat),
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
            Assert.Contains("image: './images/WalkImage.jpg'", lines);
            Assert.Equal("---", lines[8]);
        }

        [Fact]
        public void SocialFrontmatterItemsShouldBePopulated()
        {
            var evnt = new TestEvent
            {
                Sequence = 12,
                Type = EventType.Social,
                EventDate = DateTime.Parse("2023-05-04", CultureInfo.CurrentCulture.DateTimeFormat),
                Title = "Test Social",
                Depart = "9:30 Thorpe Wood",
                Length = 10.3,
                Image = "SocialImage.jpg",
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
            Assert.Contains("image: './images/SocialImage.jpg'", lines);
            Assert.Equal("---", lines[7]);
        }

        [Fact]
        public void WeekendFrontmatterItemsShouldBePopulated()
        {
            var evnt = new TestEvent
            {
                Sequence = 12,
                Type = EventType.Weekend,
                EventDate = DateTime.Parse("2023-05-04", CultureInfo.CurrentCulture.DateTimeFormat),
                Title = "Test Weekend",
                Depart = "9:30 Thorpe Wood",
                Image = "WeekendImage.jpg",
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
            Assert.Contains("image: './images/WeekendImage.jpg'", lines);
            Assert.Equal("---", lines[^2]);
            Assert.Equal(9, lines.Length);
        }

        [Fact]
        public void FrontmatterItemsShouldReplaceQuotes()
        {
            var evnt = new TestEvent
            {
                Sequence = 12,
                Type = EventType.Walk,
                EventDate = DateTime.Parse("2023-05-04", CultureInfo.CurrentCulture.DateTimeFormat),
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
            Assert.Equal("---", lines[8]);
        }

        [Fact]
        public void SocialShouldHaveLocationAndDescription()
        {
            var evnt = new TestEvent
            {
                Sequence = 12,
                Type = EventType.Social,
                EventDate = DateTime.Parse("2023-05-04", CultureInfo.CurrentCulture.DateTimeFormat),
                Title = "Test Social",
                Depart = "7:30pm The Woolpack",
                Length = 10.3,
                Image = "SocialImage.jpg",
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

            Assert.Equal(12, lines.Length);
            Assert.Equal($"Location: {evnt.Depart}", lines[8]);
            Assert.Empty(lines[9]);
            Assert.Equal(evnt.Description, lines[10]);
        }

        [Fact]
        public void WalkShouldHaveAllFields()
        {
            var evnt = new TestEvent
            {
                Sequence = 12,
                Type = EventType.Walk,
                EventDate = DateTime.Parse("2023-05-04", CultureInfo.CurrentCulture.DateTimeFormat),
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

            Assert.Equal(evnt.Description, lines[9]);
            Assert.Empty(lines[10]);
            Assert.Equal($"Length: {evnt.FormattedLength}, ({evnt.FormattedDuration})  ", lines[11]);
            Assert.Equal($"Ascent: {evnt.Ascent}  ", lines[12]);
            Assert.Equal($"Grade: {evnt.Grading}  ", lines[13]);
            Assert.Equal($"Walk Map: <a href='{evnt.Url}' target='_blank' rel='noreferrer'>OS Maps</a>  ", lines[14]);
            Assert.Empty(lines[15]);
            Assert.Equal($"Meet: {evnt.Depart}, or 9:45am at walk start  ", lines[16]);
            Assert.Equal($"Park at: {evnt.StartLocation}, ({evnt.ThreeWords})  ", lines[17]);
            Assert.Equal($"Travel Distance: {evnt.FormattedDistance}  ", lines[18]);
            Assert.Equal($"Estimated Fuel Cost: {evnt.FormattedCost} plus share of car park costs", lines[19]);
        }
    }
}
