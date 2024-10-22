using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ReportGen.Tests
{
    public class ReportToMarkDownTests
    {
        [Fact]
        public void ShouldPopulateWalkFrontMatter()
        {
            var photographers = new List<string> { "Alan", null, null };
            var files = new List<string> { "walk230421_1.jpg", "walk230421_2.jpg", "walk230421_3.jpg" };
            var captions = new List<string> { "Photo 1", "", "Photo 3" };
            var data = new ReportData(photographers, files, captions)
            {
                Id = "walk140421",
                Date = new DateTime(2021, 4, 4, 0, 0, 0, DateTimeKind.Local),
                Title = "Yelden",
                SubjectType = "Walk",
                Report = "This is an interesting walk\r\nvery interesting indeed",
                ReportBy = "Sue",
                Rating = "Average",
                CoverPhoto = "walk140421_1.jpg",
                Photographer = "Alan"
            };

            var report = new Report(data);
            var markdown = report.ToMarkDown();
            var lines = markdown.Split("\r\n");

            int i = 0;
            Assert.Equal("---", lines[i++]);
            Assert.Equal("reportId: \"walk140421\"", lines[i++]);
            Assert.Equal("reportType: \"Single\"", lines[i++]);
            Assert.Equal("title: \"Yelden\"", lines[i++]);
            Assert.Equal("reportDate: 2021-04-04T00:00:00Z", lines[i++]);
            Assert.Equal("year: 2021", lines[i++]);
            Assert.Equal("coverPhoto: \"./images/2021/walk140421_1.jpg\"", lines[i++]);
            Assert.Equal("---", lines[i]);
        }

        [Fact]
        public void ShouldPopulateGroupFrontMatter()
        {
            var data = new ReportData()
            {
                Id = "ctom2023",
                Date = new DateTime(2023, 7, 6, 0, 0, 0, DateTimeKind.Local),
                Title = "Coast To Middle",
                SubjectType = "Group",
                CoverPhoto = "IMG_7302.jpg",
                EndDate = new DateTime(2023, 7, 12, 0, 0, 0, DateTimeKind.Local)
            };

            var report = new Report(data);
            var markdown = report.ToMarkDown();
            var lines = markdown.Split("\r\n");

            int i = 0;
            Assert.Equal("---", lines[i++]);
            Assert.Equal("reportId: \"ctom2023\"", lines[i++]);
            Assert.Equal("reportType: \"Group\"", lines[i++]);
            Assert.Equal("title: \"Coast To Middle\"", lines[i++]);
            Assert.Equal("reportDate: 2023-07-06T00:00:00Z", lines[i++]);
            Assert.Equal("endDate: 2023-07-12T00:00:00Z", lines[i++]);
            Assert.Equal("year: 2023", lines[i++]);
            Assert.Equal("coverPhoto: \"./images/2023/IMG_7302.jpg\"", lines[i++]);
            Assert.Equal("---", lines[i]);
        }

        [Fact]
        public void ShouldPopulateChildFrontMatter()
        {
            var photographers = new List<string> { "Alan", null, null };
            var files = new List<string> { "walk230421_1.jpg", "walk230421_2.jpg", "walk230421_3.jpg" };
            var captions = new List<string> { "Photo 1", "", "Photo 3" };
            var data = new ReportData(photographers, files, captions)
            {
                Id = "walk140421",
                Date = new DateTime(2021, 4, 4, 0, 0, 0, DateTimeKind.Local),
                Title = "Yelden",
                SubjectType = "Day",
                Parent = "weekend-2023-1",
                Report = "This is an interesting walk\r\nvery interesting indeed",
                ReportBy = "Sue",
                Rating = "Average",
                CoverPhoto = "walk140421_1.jpg",
                Photographer = "Alan"
            };

            var report = new Report(data);
            var markdown = report.ToMarkDown();
            var lines = markdown.Split("\r\n");

            int i = 0;
            Assert.Equal("---", lines[i++]);
            Assert.Equal("reportId: \"walk140421\"", lines[i++]);
            Assert.Equal("reportType: \"Child\"", lines[i++]);
            Assert.Equal("parent: \"weekend-2023-1\"", lines[i++]);
            Assert.Equal("title: \"Yelden\"", lines[i++]);
            Assert.Equal("reportDate: 2021-04-04T00:00:00Z", lines[i++]);
            Assert.Equal("year: 2021", lines[i++]);
            Assert.Equal("coverPhoto: \"./images/2021/walk140421_1.jpg\"", lines[i++]);
            Assert.Equal("---", lines[i]);
        }

        [Fact]
        public void ShouldGenerateBodyOfReport()
        {
            var photographers = new List<string> { "Alan", null, null };
            var files = new List<string> { "walk230421_1.jpg", "walk230421_2.jpg", "walk230421_3.jpg" };
            var captions = new List<string> { "Photo 1", "", "Photo 3" };
            var data = new ReportData(photographers, files, captions)
            {
                Id = "walk040421",
                Date = new DateTime(2021, 4, 4, 0, 0, 0, DateTimeKind.Local),
                Title = "Yelden",
                SubjectType = "Walk",
                Report = "This is an interesting walk\r\nvery interesting indeed",
                ReportBy = "Sue",
                Rating = "Average",
                CoverPhoto = "walk040421_1.jpg",
                Photographer = "Alan"
            };

            var report = new Report(data);
            var markdown = report.ToMarkDown();
            var lines = markdown.Split("\r\n");

            Assert.Equal(30, lines.Length);
            int i = 8;
            Assert.Equal("This is an interesting walk", lines[i++]);
            Assert.Equal("", lines[i++]);
            Assert.Equal("very interesting indeed", lines[i++]);
            Assert.Equal("", lines[i++]);
            Assert.Equal("**Report by:** Sue   ", lines[i++]);
            Assert.Equal("**Walk Rating:** Average   ", lines[i++]);
            Assert.Equal("", lines[i++]);
            Assert.Equal("**Photographer:** Alan", lines[i++]);
            Assert.Equal("", lines[i++]);
            Assert.Equal("<center>", lines[i++]);
            Assert.Equal("", lines[i++]);
            Assert.Equal("![Photo 1](./images/2021/walk230421_1.jpg)", lines[i++]);
            Assert.Equal("Photo 1", lines[i++]);
            Assert.Equal("", lines[i++]);
            Assert.Equal("![Unknown photo](./images/2021/walk230421_2.jpg)", lines[i++]);
            Assert.Equal("", lines[i++]);
            Assert.Equal("![Photo 3](./images/2021/walk230421_3.jpg)", lines[i++]);
            Assert.Equal("Photo 3", lines[i++]);
            Assert.Equal("", lines[i++]);
            Assert.Equal("</center>", lines[i++]);
            Assert.Equal("", lines[i++]);
            Assert.Equal("", lines[i]);
        }

        [Fact]
        public void ShouldNotIncludeAuthorOrRatingInGroupReports()
        {
            var data = new ReportData()
            {
                Id = "ctom2023",
                Date = new DateTime(2023, 7, 6, 0, 0, 0, DateTimeKind.Local),
                Title = "Coast To Middle",
                SubjectType = "Group",
                CoverPhoto = "IMG_7302.jpg",
                EndDate = new DateTime(2023, 7, 12, 0, 0, 0, DateTimeKind.Local)
            };

            var report = new Report(data);
            var markdown = report.ToMarkDown();
            var lines = markdown.Split("\r\n");

            Assert.DoesNotContain(lines, l => l.Contains("**Report:**"));
            Assert.DoesNotContain(lines, l => l.Contains("**Walk Rating:**"));
        }
    }
}
