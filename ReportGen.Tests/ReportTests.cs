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
        public void ShouldPopulatePhotographer()
        {
            const string photographer = "Alan & Alexandra";
            var data = new ReportData
            {
                Photographer = photographer
            };

            var report = new Report(data);

            Assert.Equal(photographer, report.Photographer);
        }

        [Fact]
        public void ShouldPopulatePhotos()
        {
            var captions = new List<string> { "an interesting photo", "", "Something or else", "", "", "The end" };
            var files = new List<string> { "walk140421_1.jpg", "walk140421_2.jpg", "walk140421_3.jpg", "walk140421_4.jpg", "walk140421_5.jpg", "walk140421_6.jpg" };

            var data = new ReportData(files, captions);
            var report = new Report(data);

            Assert.Equal(captions.Count, report.Photos.Count);
            for(var x = 0; x < captions.Count; x++)
            {
                Assert.Equal(files[x], report.Photos[x].Filename);
                Assert.Equal(captions[x], report.Photos[x].Caption);
            }
        }

        [Fact]
        public void ShouldGenerateJson()
        {
            var files = new List<string> { "walk230421_1.jpg", "walk230421_2.jpg", "walk230421_3.jpg" };
            var captions = new List<string> { "Photo 1", "", "Photo 3" };
            var data = new ReportData(files, captions)
            {
                Id = "walk140421",
                Date = new DateTime(2021, 4, 14),
                Title = "Yelden",
                Report = "This is an interesting walk\r\nvery interesting indeed",
                ReportBy = "Sue",
                Rating = "Average",
                CoverPhoto = "walk140421_1.jpg",
                Photographer = "Alan"
            };

            var report = new Report(data);
            var json = report.ToJson();
            const string expectedPhotos = "[" +
                "{\"filename\": \"walk230421_1.jpg\", \"caption\": \"Photo 1\"}, " +
                "{\"filename\": \"walk230421_2.jpg\", \"caption\": \"\"}, " +
                "{\"filename\": \"walk230421_3.jpg\", \"caption\": \"Photo 3\"}" +
            "]";

            Assert.StartsWith("[{", json);
            Assert.Contains("\t\"id\": \"walk140421\",\r\n", json);
            Assert.Contains("\t\"date\": {\"$date\":\"2021-04-14T00:00:00Z\"},\r\n", json);
            Assert.Contains("\t\"year\": \"2021\",\r\n", json);
            Assert.Contains("\t\"title\": \"Yelden\",\r\n", json);
            Assert.Contains("\t\"report\": [\"This is an interesting walk\",\"very interesting indeed\"],\r\n", json);
            Assert.Contains("\t\"reportBy\": \"Sue\",\r\n", json);
            Assert.Contains("\t\"walkRating\": \"Average\",\r\n", json);
            Assert.Contains("\t\"coverPhoto\": \"walk140421_1.jpg\",\r\n", json);
            Assert.Contains("\t\"photographer\": \"Alan\",\r\n", json);
            Assert.Contains($"\t\"photos\": {expectedPhotos}", json);
            Assert.EndsWith("}]\r\n", json);
        }

        [Fact]
        public void ToJsonShouldOmitPhotosElementIfNoPhotos()
        {
            var data = new ReportData()
            {
                Id = "walk140421",
                Date = new DateTime(2021, 4, 14),
                Title = "Yelden",
                Report = "This is an interesting walk\r\nvery interesting indeed",
                ReportBy = "Sue",
                Rating = "Average",
                CoverPhoto = "walk140421_1.jpg",
                Photographer = "Alan"
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
            Assert.Contains("\t\"photographer\": \"Alan\",\r\n", json);
            Assert.DoesNotContain("\t\"photos\":", json);
            Assert.EndsWith("}]\r\n", json);
        }
    }
}
