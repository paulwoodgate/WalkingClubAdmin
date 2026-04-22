using System;
using System.Collections.Generic;
using Xunit;

namespace ReportGen.Tests
{
    public class ReportTests
    {
        [Fact]
        public void ShouldPopulateId()
        {
            var data = new ReportData
            {
                Id = "walk240421",
                SubjectType = "Walk",
                Date = new DateTime(2021, 4, 24, 0, 0, 0, DateTimeKind.Local)
            };

            var report = new Report(data);

            Assert.Equal("20210424", report.Id);
        }

        [Fact]
        public void ShouldPopulateDateAndYear()
        {
            var eventDate = new DateTime(2021, 5, 18, 0, 0, 0, DateTimeKind.Local);
            var data = new ReportData
            {
                Date = eventDate
            };

            var report = new Report(data);

            Assert.Equal(eventDate, report.Date);
            Assert.Equal(eventDate.Year, report.Year);
        }

        [Fact]
        public void ShouldPopulateTitle()
        {
            const string title = "Yelden";
            var data = new ReportData
            {
                Title = title
            };

            var report = new Report(data);

            Assert.Equal(title, report.Title);
        }

        [Fact]
        public void ShouldPopulateSubjectType()
        {
            const string subjectType = "Group";
            var data = new ReportData
            {
                SubjectType = subjectType
            };

            var report = new Report(data);

            Assert.Equal(subjectType, report.SubjectType);
        }

        [Fact]
        public void ShouldPopulateReportText()
        {
            const string reportText = "This is the first paragraph\r\nThis is the second paragraph\r\nand this is the third paragraph";
            var data = new ReportData
            {
                Report = reportText
            };

            var report = new Report(data);

            Assert.Equal(3, report.Text.Length);
            Assert.Equal("This is the first paragraph", report.Text[0]);
            Assert.Equal("This is the second paragraph", report.Text[1]);
            Assert.Equal("and this is the third paragraph", report.Text[2]);
        }

        [Fact]
        public void ShouldPopulateAuthor()
        {
            const string author = "Sue";
            var data = new ReportData
            {
                ReportBy = author
            };

            var report = new Report(data);

            Assert.Equal(author, report.Author);
        }

        [Fact]
        public void ShouldPopulateRating()
        {
            const string rating = "Excellent";
            var data = new ReportData
            {
                Rating = rating
            };

            var report = new Report(data);

            Assert.Equal(rating, report.Rating);
        }

        [Fact]
        public void ShouldPopulateCoverPhoto()
        {
            const string photo = "240421_1.jpg";
            var data = new ReportData
            {
                CoverPhoto = photo
            };

            var report = new Report(data);

            Assert.Equal(photo, report.CoverPhoto);
        }

        [Fact]
        public void ShouldPopulatePhotoSets()
        {
            var photographers = new List<string> { "Alan", null, null, null, null, null };
            var captions = new List<string> { "an interesting photo", "", "Something or else", "", "", "The end" };
            var files = new List<string> { "walk140421_1.jpg", "walk140421_2.jpg", "walk140421_3.jpg", "walk140421_4.jpg", "walk140421_5.jpg", "walk140421_6.jpg" };

            var data = new ReportData(photographers, files, captions);
            var report = new Report(data);

            Assert.Single(report.PhotoSets);
            var photoSet = report.PhotoSets[0];

            Assert.Equal(photographers[0], photoSet.Photographer);
            Assert.Equal(captions.Count, photoSet.Photos.Count);
            for (var x = 0; x < captions.Count; x++)
            {
                Assert.Equal(files[x], photoSet.Photos[x].Filename);
                Assert.Equal(captions[x], photoSet.Photos[x].Caption);
            }
        }

        [Fact]
        public void ShouldStripBlankLinesFromReport()
        {
            var data = new ReportData
            {
                Report = "This is paragraph 1\r\n\r\nThis is paragraph 2"
            };

            var report = new Report(data);

            Assert.Equal(2, report.Text.Length);
            Assert.Equal("This is paragraph 1", report.Text[0]);
            Assert.Equal("This is paragraph 2", report.Text[1]);
        }

        [Fact]
        public void ShouldConvertReportIdWhenReadingJson()
        {
            const string json= "{\r\n    \"id\": \"walk-2026-01-01\",\r\n    \"date\": { \"$date\": \"2026-01-01T00:00:00Z\" },\r\n    \"year\": \"2026\",\r\n    \"title\": \"Southwick\",\r\n    \"subjectType\": \"Walk\",\r\n    \"report\": [\r\n      \"Last time we did this route, Covid-19 restrictions were in place and we walked in 3 groups. That would not have been a problem today,  as at 1 point only Tina and Sue were walking, but the numbers swelled to a healthy 6. It was cold with a bitter wind when in certain directions, but at least it was dry. The derelict barn was decided to not be a good choice for our coffee break for various reasons and a bench was known to be about 30 minutes away, so we carried on. The ladies commandeered the bench for what was a quick pit stop, as we were progressing well and lunch was on the horizon - another bench (for the ladies) but where was the crocodile - I found a picture of it taken in 2020. \",\r\n      \"Alan M warned us of the impending mud as we entered the woods, he was right but it wasn’t too bad at all. \",\r\n      \"Post walk drinks were enjoyed at the busy Shuckburgh Arms following an enjoyable 1st peregrination of the year\"\r\n    ],\r\n    \"reportBy\": \"Sue\",\r\n    \"walkRating\": \"Enjoyable\",\r\n    \"coverPhoto\": \"walk111020_6.jpg\",\r\n    \"photoSets\": [{ \"photographer\": \"Sue\", \"photos\": [{ \"file\": \"walk111020_6.jpg\", \"caption\": \"\" }] }]\r\n  }";
            var report = new Report(json);
            Assert.Equal("20260101", report.Id);
        }
    }
}
