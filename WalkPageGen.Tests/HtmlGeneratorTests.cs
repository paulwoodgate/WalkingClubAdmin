using System;
using System.Collections.Generic;
using Xunit;

namespace WalkPageGen.Tests
{
    public class HtmlGeneratorTests
    {
        [Fact]
        public void ShortcutTableShouldIncludeYear()
        {
            var walks = new List<IEvent>();
            var pageGen = new HtmlGenerator(walks);
            const int year = 2020;

            var html = pageGen.CreateShortcutTable(year);

            Assert.Contains($"Walks {year}", html);
        }

        [Fact]
        public void ShortcutTableShouldBeWrappedInTableTags()
        {
            var walks = new List<IEvent>();
            var pageGen = new HtmlGenerator(walks);
            const int year = 2020;

            var html = pageGen.CreateShortcutTable(year);

            Assert.StartsWith("<table>", html);
            Assert.EndsWith("</table>", html);
        }

        [Fact]
        public void CreateShortcutTableShouldCreateTable()
        {
            var walks = new List<IEvent>
            {
                new TestEvent { Sequence = 1, Title = "Walk 1", Type = "Walk", EventDate = DateTime.Parse("2020-01-15")},
                new TestEvent { Sequence = 2, Title = "Walk 2", Type = "Walk", EventDate = DateTime.Parse("2020-01-29")},
                new TestEvent { Sequence = 3, Title = "Walk 3", Type = "Walk", EventDate = DateTime.Parse("2020-02-10")},
                new TestEvent { Sequence = 4, Title = "Walk 4", Type = "Walk", EventDate = DateTime.Parse("2020-02-24")},
                new TestEvent { Sequence = 5, Title = "Walk 5", Type = "Walk", EventDate = DateTime.Parse("2020-03-01")},
                new TestEvent { Sequence = 6, Title = "Walk 6", Type = "Walk", EventDate = DateTime.Parse("2020-03-15")},
                new TestEvent { Sequence = 7, Title = "Walk 7", Type = "Walk", EventDate = DateTime.Parse("2020-03-29")},
                new TestEvent { Sequence = 8, Title = "Walk 8", Type = "Walk", EventDate = DateTime.Parse("2020-04-13")},
                new TestEvent { Sequence = 9, Title = "Walk 9", Type = "Walk", EventDate = DateTime.Parse("2020-04-27")},
                new TestEvent { Sequence = 10, Title = "Walk 10", Type = "Walk", EventDate = DateTime.Parse("2020-05-12")},
                new TestEvent { Sequence = 11, Title = "Walk 11", Type = "Walk", EventDate = DateTime.Parse("2020-05-26")},
                new TestEvent { Sequence = 12, Title = "Walk 12", Type = "Walk", EventDate = DateTime.Parse("2020-06-09")},
                new TestEvent { Sequence = 13, Title = "Walk 13", Type = "Walk", EventDate = DateTime.Parse("2020-06-23")},
                new TestEvent { Sequence = 14, Title = "Walk 14", Type = "Walk", EventDate = DateTime.Parse("2020-07-02")},
                new TestEvent { Sequence = 15, Title = "Walk 15", Type = "Walk", EventDate = DateTime.Parse("2020-07-16")},
                new TestEvent { Sequence = 16, Title = "Walk 16", Type = "Walk", EventDate = DateTime.Parse("2020-07-30")},
                new TestEvent { Sequence = 17, Title = "Walk 17", Type = "Walk", EventDate = DateTime.Parse("2020-08-08")},
                new TestEvent { Sequence = 18, Title = "Walk 18", Type = "Walk", EventDate = DateTime.Parse("2020-08-22")},
                new TestEvent { Sequence = 19, Title = "Walk 19", Type = "Walk", EventDate = DateTime.Parse("2020-09-05")},
                new TestEvent { Sequence = 20, Title = "Walk 20", Type = "Walk", EventDate = DateTime.Parse("2020-09-19")},
                new TestEvent { Sequence = 21, Title = "Walk 21", Type = "Walk", EventDate = DateTime.Parse("2020-10-09")},
                new TestEvent { Sequence = 22, Title = "Walk 22", Type = "Walk", EventDate = DateTime.Parse("2020-10-23")},
                new TestEvent { Sequence = 23, Title = "Walk 23", Type = "Walk", EventDate = DateTime.Parse("2020-11-03")},
                new TestEvent { Sequence = 24, Title = "Walk 24", Type = "Walk", EventDate = DateTime.Parse("2020-11-17")},
                new TestEvent { Sequence = 25, Title = "Walk 25", Type = "Walk", EventDate = DateTime.Parse("2020-12-01")},
                new TestEvent { Sequence = 26, Title = "Walk 26", Type = "Walk", EventDate = DateTime.Parse("2020-12-15")}
            };

            var pageGen = new HtmlGenerator(walks);
            const int year = 2020;
            var html = pageGen.CreateShortcutTable(year);

            Assert.Contains("<td colspan=\"2\"><p>Jan</p></td>", html);
            Assert.Contains("<td colspan=\"2\"><p>Feb</p></td>", html);
            Assert.Contains("<td colspan=\"3\"><p>March</p></td>", html);
            Assert.Contains("<td colspan=\"2\"><p>April</p></td>", html);
            Assert.Contains("<td colspan=\"2\"><p>May</p></td>", html);
            Assert.Contains("<td colspan=\"2\"><p>June</p></td>", html);
            Assert.Contains("<td colspan=\"3\"><p>July</p></td>", html);
            Assert.Contains("<td colspan=\"2\"><p>Aug</p></td>", html);
            Assert.Contains("<td colspan=\"2\"><p>Sep</p></td>", html);
            Assert.Contains("<td colspan=\"2\"><p>Oct</p></td>", html);
            Assert.Contains("<td colspan=\"2\"><p>Nov</p></td>", html);
            Assert.Contains("<td colspan=\"2\"><p>Dec</p></td>", html);

            Assert.Contains("<td><p><a href=\"#walk1/2020\">15</a></p></td>", html);
        }

        [Fact]
        public void WalkShouldBeFormattedCorrectly()
        {
            const int sequence = 1;
            var date = DateTime.Parse("2020-01-05");
            const string type = "Walk";
            const int id = 21;
            const string title = "Belton";
            const string start = "Belton village";
            const string county = "Leicestershire";
            const int away = 60;
            const double length = 11.3;
            const string ascent = "177m (581ft)";
            var url = string.Empty;
            const string description = "Walking through undulation countryside in the Beane valley this route takes in 3 of the most attractive villages of Hertfordshire.";
            const string depart = "8:30am The Woodman";
            const string map = "193";
            const string w3words = "///f.f.f";
            const string gridRef = "TL 309 272";
            const string nearTo = "Stevenage";
            const string source = "Hertfordshire Walks";
            const double duration = 5.5;
            const string terrain = "Woodland paths";
            const string grading = "Standard";
            const int fuelCost = 9;
            const string image = "Belton.jpg";
            var objects = new object[]
            {
                sequence, date, type, id, title, start, county, away, length, ascent, url, w3words, description, depart,
                map, gridRef, nearTo, source, duration, terrain, grading, fuelCost, image
            };

            var walk = new Event(objects);
            var pageGen = new HtmlGenerator(new List<IEvent> { walk });
            var html = pageGen.CreateWalksList();

            Assert.StartsWith("<table>", html);
            Assert.Contains("<tr><td colspan=2 class=\"tr4\" id=\"walk1/2020\">Walk 1/2020</td></tr>", html);
            Assert.Contains("<tr><td colspan=2 class=\"tr1\">Sunday 5th January</td></tr>", html);
            Assert.Contains("<tr><td colspan=2 class=\"tr1\">Belton</td></tr>", html);
            Assert.Contains("<tr><td colspan=2 class=\"tr5\">Walking through undulation countryside in the Beane valley this route takes in 3 of the most attractive villages of Hertfordshire.</td></tr>", html);
            Assert.Contains("<tr><td></td><td></td></tr>", html);
            Assert.Contains("<tr><td>Depart:</td><td>8:30am The Woodman</td></tr>", html);
            Assert.Contains("<tr><td>Start/Finish:</td><td>Belton village</td></tr>", html);
            Assert.Contains("<tr><td>What3Words:</td><td>///f.f.f</td></tr>", html);
            Assert.Contains("<tr><td>Grid Reference:</td><td>TL 309 272</td></tr>", html);
            Assert.Contains("<tr><td>Near To:</td><td>Stevenage</td></tr>", html);
            Assert.Contains("<tr><td>Distance Away:</td><td>60 miles</td></tr>", html);
            Assert.Contains("<tr><td>Walk Length:</td><td>11.3 miles</td></tr>", html);
            Assert.Contains("<tr><td>Walk Time:</td><td>5 hours 30 minutes</td></tr>", html);
            Assert.Contains("<tr><td>Total Ascent:</td><td>177m (581ft)</td></tr>", html);
            Assert.Contains("<tr><td>Publication:</td><td>Hertfordshire Walks</td></tr>", html);
            Assert.Contains("<tr><td>Terrain:</td><td>Woodland paths</td></tr>", html);
            Assert.Contains("<tr><td>Grading:</td><td><img src=\"images/boot.gif\" class=\"boot\" alt=\"walk\">Standard</td></tr>", html);
            Assert.Contains("<tr><td>Estimated Fuel Cost:</td><td>£9.00</td></tr>", html);
            Assert.Contains("</table>", html);
            Assert.EndsWith("<h2><img class=\"ruler\" src=\"images/anarule.gif\" alt=\"line\"></h2>\r\n", html);
        }

        [Fact]
        public void WalkShouldBeFormattedCorrectlyWhenBlank()
        {
            const int sequence = 16;
            var date = DateTime.Parse("2020-08-15");
            const string type = "Walk";
            int? id = null;
            const string title = "Walk and a Meal";
            const string start = "";
            const string county = "";
            const string away = "";
            const string length = "";
            const string ascent = "";
            var url = string.Empty;
            const string w3w = "///deep.fried.marsbar";
            const string description = "";
            const string depart = "";
            const string map = "";
            const string gridRef = "";
            const string nearTo = "";
            const string source = "";
            const string duration = "";
            const string terrain = "";
            const string grading = "";
            const string fuelCost = "";
            const string image = "";
            var objects = new object[]
            {
                sequence, date, type, id, title, start, county, away, length, ascent, url, w3w, description, depart,
                map, gridRef, nearTo, source, duration, terrain, grading, fuelCost, image
            };

            var walk = new Event(objects);
            var pageGen = new HtmlGenerator(new List<IEvent> { walk });
            var html = pageGen.CreateWalksList();

            Assert.StartsWith("<table>", html);
            Assert.Contains("<tr><td colspan=2 class=\"tr4\" id=\"walk16/2020\">Walk 16/2020</td></tr>", html);
            Assert.Contains("<tr><td colspan=2 class=\"tr1\">Saturday 15th August</td></tr>", html);
            Assert.Contains("<tr><td colspan=2 class=\"tr1\">Walk and a Meal</td></tr>", html);
            Assert.Contains("<tr><td colspan=2 class=\"tr5\"></td></tr>", html);
            Assert.Contains("<tr><td></td><td></td></tr>", html);
            Assert.Contains("<tr><td>Depart:</td><td></td></tr>", html);
            Assert.Contains("<tr><td>Start/Finish:</td><td></td></tr>", html);
            Assert.Contains("<tr><td>What3Words:</td><td>///deep.fried.marsbar</td></tr>", html);
            Assert.Contains("<tr><td>Grid Reference:</td><td></td></tr>", html);
            Assert.Contains("<tr><td>Near To:</td><td></td></tr>", html);
            Assert.Contains("<tr><td>Distance Away:</td><td></td></tr>", html);
            Assert.Contains("<tr><td>Walk Length:</td><td></td></tr>", html);
            Assert.Contains("<tr><td>Walk Time:</td><td></td></tr>", html);
            Assert.Contains("<tr><td>Total Ascent:</td><td></td></tr>", html);
            Assert.Contains("<tr><td>Publication:</td><td></td></tr>", html);
            Assert.Contains("<tr><td>Terrain:</td><td></td></tr>", html);
            Assert.Contains("<tr><td>Grading:</td><td><img src=\"images/boot.gif\" class=\"boot\" alt=\"walk\">Standard</td></tr>", html);
            Assert.Contains("<tr><td>Estimated Fuel Cost:</td><td></td></tr>", html);
            Assert.Contains("</table>", html);
            Assert.EndsWith("<h2><img class=\"ruler\" src=\"images/anarule.gif\" alt=\"line\"></h2>\r\n", html);
        }

        [Fact]
        public void ShouldNotIncludeSocials()
        {
            var events = new List<IEvent>
            {
                new TestEvent { Sequence = 1, Title = "Walk 1", Type = "Walk", EventDate = DateTime.Parse("2020-01-15")},
                new TestEvent { Sequence = 2, Title = "Social 1", Type = "Social", EventDate = DateTime.Parse("2020-01-29")},
                new TestEvent { Sequence = 3, Title = "Weekend Away", Type = "Weekend", EventDate = DateTime.Parse("2020-02-10")}
            };

            var pageGen = new HtmlGenerator(events);
            var html = pageGen.CreateWalksList();

            Assert.Contains("<tr><td colspan=2 class=\"tr4\" id=\"walk1/2020\">Walk 1/2020</td></tr>", html);
            Assert.DoesNotContain("<tr><td colspan=2 class=\"tr4\" id=\"social2/2020\">Walk 2/2020</td></tr>", html);
            Assert.Contains("<tr><td colspan=2 class=\"tr4\" id=\"weekend3/2020\">Walk 3/2020</td></tr>", html);
        }
    }
}
