using System;
using System.Text.Json;
using Xunit;

namespace ReportGen.Tests
{
    public class ReportFromJsonTests
    {
        [Fact]
        public void ShouldPopulateId()
        {
            const string json = "[{\"id\": \"walk-2023-01-01\"}]";

            var report = new Report(json);

            Assert.Equal("walk-2023-01-01", report.Id);
        }

        [Fact]
        public void ShouldPopulateDate() 
        {
            const string json = "[{\"date\": { \"$date\": \"2023-12-17T00:00:00Z\"},}]";

            var report = new Report(json);

            Assert.Equal(new DateTime(2023,12,17, 0, 0, 0, DateTimeKind.Local), report.Date);
        }

        [Fact]
        public void ShouldPopulateEndDate()
        {
            const string json = "[{\"endDate\": { \"$date\": \"2023-12-17T00:00:00Z\"},}]";

            var report = new Report(json);

            Assert.Equal(new DateTime(2023, 12, 17, 0, 0, 0, DateTimeKind.Local), report.EndDate);
        }

        [Fact]
        public void ShouldPopulateParentForDayEvents()
        {
            const string json = "[{\"id\": \"weekend-2023-1\", \"subjectType\": \"Day\"}]";

            var report = new Report(json);

            Assert.Equal("weekend-2023", report.Parent);
        }

        [Fact]
        public void ShouldPopulateParentWithMultiCharSuffix()
        {
            const string json = "[{\"id\": \"weekend-2023-2a\", \"subjectType\": \"Day\"}]";

            var report = new Report(json);

            Assert.Equal("weekend-2023", report.Parent);
        }

        [Fact]
        public void ShouldNotPopulateParentForNonDayEvents()
        {
            const string json = "[{\"id\": \"weekend-2023-1\", \"subjectType\": \"Walk\"}]";

            var report = new Report(json);

            Assert.Null(report.Parent);
        }

        [Fact]
        public void ShouldLeaveEndDateNullIfMissing()
        {
            const string json = "[{\"date\": { \"$date\": \"2023-12-17T00:00:00Z\"},}]";

            var report = new Report(json);

            Assert.Null(report.EndDate);
        }

        [Fact]
        public void ShouldPopulateTitle()
        {
            const string json = "[{\"title\": \"East Carlton\"}]";

            var report = new Report(json);

            Assert.Equal("East Carlton", report.Title);
        }

        [Fact]
        public void ShouldPopulateSubjectType()
        {
            const string json = "[{\"subjectType\": \"Walk\"}]";

            var report = new Report(json);

            Assert.Equal("Walk", report.SubjectType);
        }

        [Fact]
        public void ShouldPopulateReportText()
        {
            const string json = "[{\"report\": [\"Para 1\",\"Para 2\",\"Para 3\"]}]";

            var report = new Report(json);

            Assert.Equal(3, report.Text.Length);
            Assert.Equal("Para 1", report.Text[0]);
            Assert.Equal("Para 2", report.Text[1]);
            Assert.Equal("Para 3", report.Text[2]);
        }

        [Fact]
        public void ShouldPopulateAuthor()
        {
            const string json = "[{\"reportBy\": \"Paul\"}]";

            var report = new Report(json);

            Assert.Equal("Paul", report.Author);
        }

        [Fact]
        public void ShouldPopulateRating()
        {
            const string json = "[{\"walkRating\": \"Very Good\"}]";

            var report = new Report(json);

            Assert.Equal("Very Good", report.Rating);
        }

        [Fact]
        public void ShouldPopulateCoverPhoto()
        {
            const string json = "[{\"coverPhoto\": \"walk010124~1.jpg\"}]";

            var report = new Report(json);

            Assert.Equal("walk010124~1.jpg", report.CoverPhoto);
        }

        [Fact]
        public void ShouldPopulatePhotoSet()
        {
            const string json = "[    \"photoSets\": [\r\n      {\r\n        \"photographer\": \"Alan\",\r\n        \"photos\": [\r\n          { \"file\": \"walk020224~1.jpg\", \"caption\": \"Lower Slaughter\" },\r\n          { \"file\": \"walk020224~2.jpg\", \"caption\": \"Water Mill on the way out of Lower Slaughter\" },\r\n        ]\r\n      }]";

            var report = new Report(json);

            Assert.NotNull(report.PhotoSets);
            Assert.Equal("Alan", report.PhotoSets[0].Photographer);
            Assert.Equal(2, report.PhotoSets[0].Photos.Count);
            Assert.Equal("walk020224~1.jpg", report.PhotoSets[0].Photos[0].Filename);
            Assert.Equal("Lower Slaughter", report.PhotoSets[0].Photos[0].Caption);
        }
    }
}
