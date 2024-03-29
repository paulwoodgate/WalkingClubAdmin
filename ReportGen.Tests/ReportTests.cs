﻿using System;
using System.Collections.Generic;
using Xunit;

namespace ReportGen.Tests
{
    public class ReportTests
    {
        [Fact]
        public void ShouldPopulateId()
        {
            const string id = "walk240421";
            var data = new ReportData
            {
                Id = id
            };

            var report = new Report(data);

            Assert.Equal(id, report.Id);
        }

        [Fact]
        public void ShouldPopulateDateAndYear()
        {
            var eventDate = new DateTime(2021, 5, 18);
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
            for(var x = 0; x < captions.Count; x++)
            {
                Assert.Equal(files[x], photoSet.Photos[x].Filename);
                Assert.Equal(captions[x], photoSet.Photos[x].Caption);
            }
        }

        [Fact]
        public void ShouldGenerateJson()
        {
            var photographers = new List<string> { "Alan", null, null };
            var files = new List<string> { "walk230421_1.jpg", "walk230421_2.jpg", "walk230421_3.jpg" };
            var captions = new List<string> { "Photo 1", "", "Photo 3" };
            var data = new ReportData(photographers, files, captions)
            {
                Id = "walk140421",
                Date = new DateTime(2021, 4, 14),
                Title = "Yelden",
                SubjectType = "Day",
                Report = "This is an interesting walk\r\nvery interesting indeed",
                ReportBy = "Sue",
                Rating = "Average",
                CoverPhoto = "walk140421_1.jpg",
                Photographer = "Alan"
            };

            var report = new Report(data);
            var json = report.ToJson();
            const string expectedPhotos = "[" +
                "{\"file\": \"walk230421_1.jpg\", \"caption\": \"Photo 1\"}, " +
                "{\"file\": \"walk230421_2.jpg\", \"caption\": \"\"}, " +
                "{\"file\": \"walk230421_3.jpg\", \"caption\": \"Photo 3\"}" +
            "]";
            const string expectedPhotoSets = "[{" +
            "\"photographer\": \"Alan\", " +
            "\"photos\": " + expectedPhotos +
            "}]";


            Assert.StartsWith("[{", json);
            Assert.Contains("\t\"id\": \"walk140421\",\r\n", json);
            Assert.Contains("\t\"date\": {\"$date\":\"2021-04-14T00:00:00Z\"},\r\n", json);
            Assert.Contains("\t\"year\": \"2021\",\r\n", json);
            Assert.Contains("\t\"title\": \"Yelden\",\r\n", json);
            Assert.Contains("\t\"subjectType\": \"Day\",\r\n", json);
            Assert.Contains("\t\"report\": [\"This is an interesting walk\",\"very interesting indeed\"],\r\n", json);
            Assert.Contains("\t\"reportBy\": \"Sue\",\r\n", json);
            Assert.Contains("\t\"walkRating\": \"Average\",\r\n", json);
            Assert.Contains("\t\"coverPhoto\": \"walk140421_1.jpg\",\r\n", json);
            Assert.Contains($"\t\"photoSets\": {expectedPhotoSets}", json);
            Assert.EndsWith("}]\r\n", json);
        }

        [Fact]
        public void ShouldGenerateJsonForGroup()
        {
            var photographers = new List<string> { "Alan", null, null };
            var files = new List<string> { "walk230421_1.jpg", "walk230421_2.jpg", "walk230421_3.jpg" };
            var captions = new List<string> { "Photo 1", "", "Photo 3" };
            var data = new ReportData(photographers, files, captions)
            {
                Id = "walk140421",
                Date = new DateTime(2021, 4, 14),
                EndDate = new DateTime(2021, 4, 17),
                Title = "Yelden",
                SubjectType = "Group",
                CoverPhoto = "walk140421_1.jpg"
            };

            var report = new Report(data);
            var json = report.ToJson();

            Assert.StartsWith("[{", json);
            Assert.Contains("\t\"id\": \"walk140421\",\r\n", json);
            Assert.Contains("\t\"date\": {\"$date\":\"2021-04-14T00:00:00Z\"},\r\n", json);
            Assert.Contains("\t\"endDate\": {\"$date\":\"2021-04-17T00:00:00Z\"},\r\n", json);
            Assert.Contains("\t\"year\": \"2021\",\r\n", json);
            Assert.Contains("\t\"title\": \"Yelden\",\r\n", json);
            Assert.Contains("\t\"subjectType\": \"Group\",\r\n", json);
            Assert.Contains("\t\"coverPhoto\": \"walk140421_1.jpg\",\r\n", json);
            Assert.DoesNotContain("\t\"report\": [", json);
            Assert.DoesNotContain("\t\"reportBy\": ", json);
            Assert.DoesNotContain("\t\"walkRating\": ", json);
            Assert.DoesNotContain("\"photographer\": ", json);
            Assert.DoesNotContain("\"photos\": ", json);
            Assert.EndsWith("}]\r\n", json);
        }

        [Fact]
        public void ToJsonShouldOmitPhotoSetsElementIfNoPhotos()
        {
            var data = new ReportData()
            {
                Id = "walk140421",
                Date = new DateTime(2021, 4, 14),
                Title = "Yelden",
                Report = "This is an interesting walk\r\nvery interesting indeed",
                ReportBy = "Sue",
                Rating = "Average",
                CoverPhoto = "walk140421_1.jpg"
            };

            var report = new Report(data);
            var json = report.ToJson();

            Assert.StartsWith("[{", json);
            Assert.Contains("\t\"id\": \"walk140421\",\r\n", json);
            Assert.Contains("\t\"date\": {\"$date\":\"2021-04-14T00:00:00Z\"},\r\n", json);
            Assert.Contains("\t\"year\": \"2021\",\r\n", json);
            Assert.Contains("\t\"title\": \"Yelden\",\r\n", json);
            Assert.Contains("\t\"report\": [\"This is an interesting walk\",\"very interesting indeed\"],\r\n", json);
            Assert.Contains("\t\"reportBy\": \"Sue\",\r\n", json);
            Assert.Contains("\t\"walkRating\": \"Average\",\r\n", json);
            Assert.Contains("\t\"coverPhoto\": \"walk140421_1.jpg\",\r\n", json);
            Assert.DoesNotContain("\t\"photoSets\":", json);
            Assert.EndsWith("}]\r\n", json);
        }

        [Fact]
        public void ToJsonShouldEscapeDoubleQuotesInText()
        {
            const string reportText = "This has \"quote\" marks";

            var data = new ReportData
            {
                Report = reportText
            };

            var report = new Report(data);
            var json = report.ToJson();

            Assert.Contains("\t\"report\": [\"This has \\\"quote\\\" marks\"],\r\n", json);
        }

        [Fact]
        public void ToJsonShouldEscapeDoubleQuotesInCaptions()
        {
            var photographers = new List<string> { "Alan" };
            var captions = new List<string> { "an \"interesting\" photo" };
            var files = new List<string> { "walk140421_1.jpg" };

            var data = new ReportData(photographers, files, captions);
            var report = new Report(data);
            var json = report.ToJson();

            Assert.Contains("\"caption\": \"an \\\"interesting\\\" photo\"", json);
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
    }
}
