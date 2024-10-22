using System;
using System.Collections.Generic;
using Xunit;

namespace ReportGen.Tests
{
    public class ReportToJsonTests
    {
        [Fact]
        public void ShouldGenerateJson()
        {
            var photographers = new List<string> { "Alan", null, null };
            var files = new List<string> { "walk230421_1.jpg", "walk230421_2.jpg", "walk230421_3.jpg" };
            var captions = new List<string> { "Photo 1", "", "Photo 3" };
            var data = new ReportData(photographers, files, captions)
            {
                Id = "walk140421",
                Date = new DateTime(2021, 4, 14, 0, 0, 0, DateTimeKind.Local),
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
                Date = new DateTime(2021, 4, 14, 0, 0, 0, DateTimeKind.Local),
                EndDate = new DateTime(2021, 4, 17, 0, 0, 0, DateTimeKind.Local),
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
                Date = new DateTime(2021, 4, 14, 0, 0, 0, DateTimeKind.Local),
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
            Assert.Contains("\t\"coverPhoto\": \"walk140421_1.jpg\"\r\n", json);
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

    }
}
