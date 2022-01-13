using System;
using System.Collections.Generic;
using Xunit;

namespace ReportGen.Tests
{
    public class ReportDataTests
    {
        [Fact]
        public void ShouldInitialisePhotosList()
        {
            var data = new ReportData();

            Assert.NotNull(data.Photos);
        }

        [Fact]
        public void ShouldThrowExceptionIfDifferentNumbersOfFilesAndCaptions()
        {
            var files = new List<string> { "file1.jpg", "file2.jpg", "file2.jpg" };
            var captions = new List<string> { "Caption1", "Caption2" };

            var ex = Assert.Throws<ArgumentException>(() => new ReportData(files, captions));
            Assert.Equal("You must supply the same number of captions as files", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfNoId()
        {
            var data = new ReportData();

            var ex = Assert.Throws<ArgumentException>(() => data.Validate());
            Assert.Equal("You must enter an ID for the report.", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfNoTitle()
        {
            var data = new ReportData
            {
                Id = "Walk_240421"
            };

            var ex = Assert.Throws<ArgumentException>(() => data.Validate());
            Assert.Equal("You must enter the title of the event.", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfNoEndDateandGroup()
        {
            var data = new ReportData
            {
                Id = "Walk_240421",
                Title = "A walk on the wild side",
                Date = new DateTime(2021, 12, 31),
                SubjectType = "Group"
            };

            var ex = Assert.Throws<ArgumentException>(() => data.Validate());
            Assert.Equal("You must enter the end date of the event.", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfEndDateBeforeDate()
        {
            var data = new ReportData
            {
                Id = "Walk_240421",
                Title = "A walk on the wild side",
                Date = new DateTime(2021, 12, 31),
                EndDate = new DateTime(2021, 12, 30),
                SubjectType = "Group"
            };

            var ex = Assert.Throws<ArgumentException>(() => data.Validate());
            Assert.Equal("You must enter a valid end date for the event.", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfEndDateAfterToday()
        {
            var data = new ReportData
            {
                Id = "Walk_240421",
                Title = "A walk on the wild side",
                Date = DateTime.Today,
                EndDate = DateTime.Today.AddDays(1),
                SubjectType = "Group"
            };

            var ex = Assert.Throws<ArgumentException>(() => data.Validate());
            Assert.Equal("You must enter a valid end date for the event.", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfNoDate()
        {
            var data = new ReportData
            {
                Id = "Walk_240421",
                Title = "A walk on the wild side"
            };

            var ex = Assert.Throws<ArgumentException>(() => data.Validate());
            Assert.Equal("You must enter the date of the event.", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfDateBefore1stJan2000()
        {
            var data = new ReportData
            {
                Id = "Walk_240421",
                Title = "A walk on the wild side",
                Date = new DateTime(1999, 12, 31)
            };

            var ex = Assert.Throws<ArgumentException>(() => data.Validate());
            Assert.Equal("You must enter a valid date for the event.", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfDateAfterToday()
        {
            var data = new ReportData
            {
                Id = "Walk_240421",
                Title = "A walk on the wild side",
                Date = DateTime.Today.AddDays(1)
            };

            var ex = Assert.Throws<ArgumentException>(() => data.Validate());
            Assert.Equal("You must enter a valid date for the event.", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfInvalidSubjectType()
        {
            var data = new ReportData
            {
                Id = "walk_2021_02",
                Title = "Walk Title",
                Date = DateTime.Today,
                SubjectType = "week"
            };

            var ex = Assert.Throws<ArgumentException>(() => data.Validate());
            Assert.Equal("The Subject Type must be empty, Day, or Group", ex.Message);
        }
        [Fact]
        public void ValidateShouldReturnTrueIfSuccessful()
        {
            var data = new ReportData
            {
                Id = "Walk_240421",
                Title = "A walk on the wild side",
                Date = DateTime.Today
            };

            var success = data.Validate();
            Assert.True(success);
        }
    }
}
