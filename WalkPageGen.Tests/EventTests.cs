using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WalkPageGen.Tests
{
    public class EventTests
    {
        [Fact]
        public void ShouldErrorIfLessThan23Values()
        {
            var values = new object[] { 1, DateTime.Today, "Walk", "walk-01", "Walk title" };

            Exception ex = Assert.Throws<ArgumentException>(() => new Event(values));
            Assert.Equal("A walk needs 23 values", ex.Message);
        }

        [Fact]
        public void ShouldReturnAnEventObjectForAWalk()
        {
            const int sequence = 1;
            var date = DateTime.Today;
            const EventType type = EventType.Walk;
            const string title = "Walk title";
            const string start = "The car park";
            const string county = "Essex";
            const double distanceAway = 24;
            const double length = 6.7;
            const string ascent = "Lots";
            const string url = "http://www.google.com";
            const string w3w = "somewhere.new.again";
            const string description = "Walk description";
            const string leave = "Too early";
            const string map = "OL2";
            const string mapRef = "HB 123 456";
            const string closeTo = "Nowhere";
            const string source = "From Map";
            const double duration = 4.5;
            const string terrain = "Mud";
            const string grading = "Standard";
            const double fuelCost = 2.5;
            const string image = "empty.png";

            var values = new object[] { sequence, date, type.ToString(), 3, title, start, county, distanceAway, length, ascent, url, w3w, description,
                leave, map, mapRef, closeTo, source, duration, terrain, grading, fuelCost, image};

            var ev = new Event(values);

            Assert.Equal(sequence, ev.Sequence);
            Assert.Equal(date, ev.EventDate);
            Assert.Equal(type, ev.Type);
            Assert.Equal(title, ev.Title);
            Assert.Equal(start, ev.StartLocation);
            Assert.Equal(county, ev.County);
            Assert.Equal(distanceAway, ev.DistanceAway);
            Assert.Equal(length, ev.Length);
            Assert.Equal(ascent, ev.Ascent);
            Assert.Equal(url, ev.Url);
            Assert.Equal(w3w, ev.ThreeWords);
            Assert.Equal(description, ev.Description);
            Assert.Equal(leave, ev.Depart);
            Assert.Equal(map, ev.Map);
            Assert.Equal(mapRef, ev.StartGridRef);
            Assert.Equal(closeTo, ev.NearTo);
            Assert.Equal(source, ev.Source);
            Assert.Equal(duration, ev.Duration);
            Assert.Equal(terrain, ev.Terrain);
            Assert.Equal(grading, ev.Grading.ToString());
            Assert.Equal(fuelCost, ev.FuelCost);
            Assert.Equal(image, ev.Image);
        }

        [Fact]
        public void ShouldReturnAnEventObjectForAWeekend()
        {
            const int sequence = 1;
            var date = DateTime.Today;
            const EventType type = EventType.Weekend;
            const string title = "Walk title";
            const string start = "The car park";
            const string county = "Essex";
            const double distanceAway = 24;
            const double length = 6.7;
            const string ascent = "Lots";
            const string url = "http://www.google.com";
            const string w3w = "somewhere.new.again";
            const string description = "Walk description";
            const string leave = "Too early";
            const string map = "OL2";
            const string mapRef = "HB 123 456";
            const string closeTo = "Nowhere";
            const string source = "From Map";
            const double duration = 4.5;
            const string terrain = "Mud";
            const string grading = "Standard";
            const double fuelCost = 2.5;
            const string image = "empty.png";
            const int nights = 3;

            var values = new object[] { sequence, date, type.ToString(), 3, title, start, county, distanceAway, length, ascent, url, w3w, description,
                leave, map, mapRef, closeTo, source, duration, terrain, grading, fuelCost, image, nights};

            var ev = new Event(values);

            Assert.Equal(sequence, ev.Sequence);
            Assert.Equal(date, ev.EventDate);
            Assert.Equal(type, ev.Type);
            Assert.Equal(title, ev.Title);
            Assert.Equal(start, ev.StartLocation);
            Assert.Equal(county, ev.County);
            Assert.Equal(distanceAway, ev.DistanceAway);
            Assert.Equal(length, ev.Length);
            Assert.Equal(ascent, ev.Ascent);
            Assert.Equal(url, ev.Url);
            Assert.Equal(w3w, ev.ThreeWords);
            Assert.Equal(description, ev.Description);
            Assert.Equal(leave, ev.Depart);
            Assert.Equal(map, ev.Map);
            Assert.Equal(mapRef, ev.StartGridRef);
            Assert.Equal(closeTo, ev.NearTo);
            Assert.Equal(source, ev.Source);
            Assert.Equal(duration, ev.Duration);
            Assert.Equal(terrain, ev.Terrain);
            Assert.Equal(grading, ev.Grading.ToString());
            Assert.Equal(fuelCost, ev.FuelCost);
            Assert.Equal(image, ev.Image);
            Assert.Equal(nights, ev.Nights);
        }

        [Fact]
        public void ShouldThrowAnExceptionIfGradingIsInvalid()
        {
            var values = new object[] { 1, DateTime.Today, "Walk", "walk-01", "Walk title", "The car park", "Essex", 24, 6.7, "Lots",
                "http://www.google.com", "somewhere.new.again", "Walk description", "too early", "OL2", "HB 123 456", "Nowhere", "From map",
                4.5, "Mud", "Yuck", 2.5, "empty.png"};

            Exception ex = Assert.Throws<ArgumentException>(() => new Event(values));
            Assert.Equal("Yuck is not a valid walk grading", ex.Message);
        }

        [Fact]
        public void ShouldThrowAnExceptionIfWeekendAndNoNights()
        {
            var values = new object[] { 1, DateTime.Today, "Weekend", "weekend-01", "Walk title", "The car park", "Essex", 24, 6.7, "Lots",
                "http://www.google.com", "somewhere.new.again", "Walk description", "too early", "OL2", "HB 123 456", "Nowhere", "From map",
                4.5, "Mud", "Standard", 2.5, "empty.png"};

            Exception ex = Assert.Throws<ArgumentException>(() => new Event(values));
            Assert.Equal("You must supply the number of nights for a weekend", ex.Message);
        }

        [Fact]
        public void ShouldThrowAnExceptionIfNegativeNights()
        {
            const int sequence = 1;
            var date = DateTime.Today;
            const EventType type = EventType.Weekend;
            const string title = "Walk title";
            const string start = "The car park";
            const string county = "Essex";
            const double distanceAway = 24;
            const double length = 6.7;
            const string ascent = "Lots";
            const string url = "http://www.google.com";
            const string w3w = "somewhere.new.again";
            const string description = "Walk description";
            const string leave = "Too early";
            const string map = "OL2";
            const string mapRef = "HB 123 456";
            const string closeTo = "Nowhere";
            const string source = "From Map";
            const double duration = 4.5;
            const string terrain = "Mud";
            const string grading = "Standard";
            const double fuelCost = 2.5;
            const string image = "empty.png";
            const int nights = -1;

            var values = new object[] { sequence, date, type.ToString(), 3, title, start, county, distanceAway, length, ascent, url, w3w, description,
                leave, map, mapRef, closeTo, source, duration, terrain, grading, fuelCost, image, nights};

            Exception ex = Assert.Throws<ArgumentException>(() => new Event(values));
            Assert.Equal("The number of nights must be greater than 0", ex.Message);
        }

        [Fact]
        public void ShouldIgnoreNegativeNightsIfNotWeekend()
        {
            const int sequence = 1;
            var date = DateTime.Today;
            const EventType type = EventType.Walk;
            const string title = "Walk title";
            const string start = "The car park";
            const string county = "Essex";
            const double distanceAway = 24;
            const double length = 6.7;
            const string ascent = "Lots";
            const string url = "http://www.google.com";
            const string w3w = "somewhere.new.again";
            const string description = "Walk description";
            const string leave = "Too early";
            const string map = "OL2";
            const string mapRef = "HB 123 456";
            const string closeTo = "Nowhere";
            const string source = "From Map";
            const double duration = 4.5;
            const string terrain = "Mud";
            const string grading = "Standard";
            const double fuelCost = 2.5;
            const string image = "empty.png";
            const int nights = -3;

            var values = new object[] { sequence, date, type.ToString(), 3, title, start, county, distanceAway, length, ascent, url, w3w, description,
                leave, map, mapRef, closeTo, source, duration, terrain, grading, fuelCost, image, nights};

            var ev = new Event(values);

            Assert.Equal(sequence, ev.Sequence);
            Assert.Equal(date, ev.EventDate);
            Assert.Equal(type, ev.Type);
            Assert.Equal(title, ev.Title);
            Assert.Equal(start, ev.StartLocation);
            Assert.Equal(county, ev.County);
            Assert.Equal(distanceAway, ev.DistanceAway);
            Assert.Equal(length, ev.Length);
            Assert.Equal(ascent, ev.Ascent);
            Assert.Equal(url, ev.Url);
            Assert.Equal(w3w, ev.ThreeWords);
            Assert.Equal(description, ev.Description);
            Assert.Equal(leave, ev.Depart);
            Assert.Equal(map, ev.Map);
            Assert.Equal(mapRef, ev.StartGridRef);
            Assert.Equal(closeTo, ev.NearTo);
            Assert.Equal(source, ev.Source);
            Assert.Equal(duration, ev.Duration);
            Assert.Equal(terrain, ev.Terrain);
            Assert.Equal(grading, ev.Grading.ToString());
            Assert.Equal(fuelCost, ev.FuelCost);
            Assert.Equal(image, ev.Image);
            Assert.Null(ev.Nights);
        }
    }
}
