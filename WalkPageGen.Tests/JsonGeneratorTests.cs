// Ignore Spelling: Json Mongo

using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;

namespace WalkPageGen.Tests
{
    public class JsonGeneratorTests
    {
        [Fact]
        public void ShouldReturnAnArray()
        {
            var json = JsonGenerator.CreateJson(new List<IEvent>(), false);

            Assert.StartsWith("[", json);
            Assert.EndsWith("]\r\n", json);
        }

        [Fact]
        public void ShouldReturnWalkObject()
        {
            var walks = new List<IEvent>
            {
                new TestEvent()
            };
            const string expected = "\t\t\"type\": \"Walk\",\r\n";
            var json = JsonGenerator.CreateJson(walks, false);

            Assert.Contains(expected, json);
        }

        [Fact]
        public void ShouldReturnWalkObjectsSeparatedByComma()
        {
            var walks = new List<IEvent>
            {
                new TestEvent{Sequence = 1, Type = EventType.Walk, EventDate = DateTime.Parse("2020-01-05", CultureInfo.CurrentCulture.DateTimeFormat)},
                new TestEvent{Sequence = 2, Type = EventType.Walk, EventDate = DateTime.Parse("2020-01-19", CultureInfo.CurrentCulture.DateTimeFormat)}
            };

            var json = JsonGenerator.CreateJson(walks, false);

            Assert.Contains("\t},\r\n\t{\r\n", json);
        }

        [Fact]
        public void ShouldExportWeekends()
        {
            var walks = new List<IEvent>
            {
                new TestEvent{Sequence = 1, Type = EventType.Walk, EventDate = DateTime.Parse("2020-01-05", CultureInfo.CurrentCulture.DateTimeFormat)},
                new TestEvent{Sequence = 2, Type = EventType.Weekend, EventDate = DateTime.Parse("2020-01-05", CultureInfo.CurrentCulture.DateTimeFormat), IsRoute = false},
                new TestEvent{Sequence = 3, Type = EventType.Social, EventDate = DateTime.Parse("2020-01-19", CultureInfo.CurrentCulture.DateTimeFormat), IsRoute = false}
            };
            const string expected1 = "\t\t\"id\": \"walk-2020-01\",\r\n";
            const string expected2 = "\t\t\"id\": \"weekend-2020-02\",\r\n";
            const string expected3 = "\t\t\"id\": \"social-2020-03\",\r\n";

            var json = JsonGenerator.CreateJson(walks, false);

            Assert.Contains(expected1, json);
            Assert.Contains(expected2, json);
            Assert.Contains(expected3, json);
        }

        [Fact]
        public void ShouldExportAllFields()
        {
            const int sequence = 1;
            var date = DateTime.Parse("2020-01-05", CultureInfo.CurrentCulture.DateTimeFormat);
            const string type = "Walk";
            const int id = 21;
            const string title = "Belton";
            const string start = "Belton village";
            const string county = "Leicestershire";
            const int away = 60;
            const double length = 11.3;
            const string ascent = "177m (581ft)";
            var url = string.Empty;
            const string description = "[Walking through undulating countryside in the Beane valley this route takes in 3 of the most attractive villages of Hertfordshire.]";
            const string depart = "8:30am The Woodman";
            const string map = "193";
            const string w3words = "///f.f.f";
            const string gridRef = "TL 309 272";
            const string nearTo = "Stevenage";
            const string source = "Hertfordshire Walks";
            const double duration = 5.5;
            const string terrain = "Woodland paths";
            const string grading = "Standard";
            const double fuelCost = 9;
            const string image = "Belton.png";

            var objects = new object[]
            {
                sequence, date, type, id, title, county, start, away, length, ascent, url, w3words, description, depart,
                map, gridRef, nearTo, source, duration, terrain, grading, fuelCost, image
            };

            var walk = new Event(objects);
            var json = JsonGenerator.CreateJson(new List<IEvent> { walk }, false);

            Assert.Contains("\t\t\"id\": \"walk-2020-01\",\r\n", json);
            Assert.Contains("\t\t\"date\": \"2020-01-05T00:00:00Z\",\r\n", json);
            Assert.Contains("\t\t\"title\": \"Belton\",\r\n", json);
            Assert.Contains("\t\t\"startFrom\": \"Belton village\",\r\n", json);
            Assert.Contains($"\t\t\"distanceAway\": {away},\r\n", json);
            Assert.Contains($"\t\t\"county\": \"{county}\",\r\n", json);
            Assert.Contains($"\t\t\"length\": {length:n1},\r\n", json);
            Assert.Contains($"\t\t\"ascent\": \"{ascent}\",\r\n", json);
            Assert.Contains($"\t\t\"description\": \"{description}\",\r\n", json);
            Assert.Contains($"\t\t\"leave\": \"{depart}\",\r\n", json);
            Assert.Contains($"\t\t\"w3wReference\": \"{w3words}\",\r\n", json);
            Assert.Contains($"\t\t\"mapReference\": \"{gridRef}\",\r\n", json);
            Assert.Contains($"\t\t\"nearTo\": \"{nearTo}\",\r\n", json);
            Assert.Contains("\t\t\"source\": {\r\n" +
                $"\t\t\t\"name\": \"{source}\",\r\n" +
                $"\t\t\t\"url\": \"{url}\"\r\n" +
                "\t\t}", json);
            Assert.Contains($"\t\t\"walkTime\": {duration:n1},\r\n", json);
            Assert.Contains($"\t\t\"terrain\": \"{terrain}\",\r\n", json);
            Assert.Contains($"\t\t\"grading\": \"{grading}\",\r\n", json);
            Assert.Contains($"\t\t\"fuelCost\": {fuelCost:n1}\r\n", json);
            Assert.Contains($"\t\t\"image\": \"{image}\",\r\n", json);
        }

        [Fact]
        public void ShouldUseMongoDateFormat()
        {
            var walks = new List<IEvent>
            {
                new TestEvent{Sequence = 1, Type = EventType.Social, EventDate = DateTime.Parse("2020-01-05", CultureInfo.CurrentCulture.DateTimeFormat)}
            };
            const string expected = "\t\t\"date\": {\"$date\":\"2020-01-05T00:00:00Z\"},\r\n";

            var json = JsonGenerator.CreateJson(walks, true);

            Assert.Contains(expected, json);
        }

        [Fact]
        public void ShouldIncludeZeroAfterDecimalPointOnNumericFields()
        {
            var testEvent = new TestEvent{
                    Sequence = 1,
                    Type = EventType.Walk,
                    EventDate = DateTime.Parse("2020-01-05", CultureInfo.CurrentCulture.DateTimeFormat),
                    Duration=5,
                    FuelCost=5,
                    Length=10
            };
            var expectedLength = $"\t\t\"length\": {testEvent.Length:N1},\r\n";
            var expectedWalkTime = $"\t\t\"walkTime\": {testEvent.Duration:N1},\r\n";
            var expectedFuelCost = $"\t\t\"fuelCost\": {testEvent.FuelCost:N1}\r\n";

            var json = JsonGenerator.CreateJson(new List<IEvent> { testEvent }, true);

            Assert.Contains(expectedWalkTime, json);
            Assert.Contains(expectedLength, json);
            Assert.Contains(expectedFuelCost, json);
        }

        [Theory]
        [InlineData(EventType.Social)]
        [InlineData(EventType.Walk)]
        [InlineData(EventType.Weekend)]
        public void ShouldHaveCorrectEventTypeAndId(EventType eventType)
        {
            var testEvent = new TestEvent
            {
                Sequence = 1,
                Type = eventType,
                EventDate = DateTime.Parse("2020-01-05", CultureInfo.CurrentCulture.DateTimeFormat),
                Duration = 5,
                FuelCost = 5,
                Length = 10
            };
            var expectedType = $"\t\t\"type\": \"{testEvent.Type}\",\r\n";
            var expectedId = $"\t\t\"id\": \"{testEvent.Type.ToString().ToLower()}-{testEvent.EventDate.Year}-{testEvent.Sequence:D2}\",\r\n";

            var json = JsonGenerator.CreateJson(new List<IEvent> { testEvent }, true);

            Assert.Contains(expectedType, json);
            Assert.Contains(expectedId, json);
        }
    }
}
