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

            Assert.NotNull(data.PhotoSets);
        }

        [Fact]
        public void ShouldThrowExceptionIfDifferentNumbersOfFilesAndCaptions()
        {
            var files = new List<string> { "file1.jpg", "file2.jpg", "file2.jpg" };
            var captions = new List<string> { "Caption1", "Caption2" };
            var photographers = new List<string> { "Alan", null, null };

            var ex = Assert.Throws<ArgumentException>(() => new ReportData(photographers, files, captions));
            Assert.Equal("You must supply the same number of photographers and captions as files", ex.Message);
        }

        [Fact]
        public void ShouldThrowExceptionIfDifferentNumbersOfFilesAndPhotographers()
        {
            var files = new List<string> { "file1.jpg", "file2.jpg", "file2.jpg" };
            var captions = new List<string> { "Caption1", "Caption2", "" };
            var photographers = new List<string> { "Alan", null };

            var ex = Assert.Throws<ArgumentException>(() => new ReportData(photographers, files, captions));
            Assert.Equal("You must supply the same number of photographers and captions as files", ex.Message);
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
        public void ValidateShouldErrorIfNoEndDateAndGroup()
        {
            var data = new ReportData
            {
                Id = "Walk_240421",
                Title = "A walk on the wild side",
                Date = new DateTime(2021, 12, 31, 0, 0, 0, DateTimeKind.Local),
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
                Date = new DateTime(2021, 12, 31, 0, 0, 0, DateTimeKind.Local),
                EndDate = new DateTime(2021, 12, 30, 0, 0, 0, DateTimeKind.Local),
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
                Date = new DateTime(1999, 12, 31, 0, 0, 0, DateTimeKind.Local)
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
            Assert.Equal("The Subject Type must be empty, Day, Group, or Walk", ex.Message);
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

        [Fact]
        public void ShouldCreatePhotoSet()
        {
            var files = new List<string> { "file1.jpg", "file2.jpg", "file2.jpg" };
            var captions = new List<string> { "Caption1", "Caption2", "Caption3" };
            var photographers = new List<string> { "Alan", null, null };

            var data = new ReportData(photographers, files, captions);

            Assert.Single(data.PhotoSets);
            Assert.Equal("Alan", data.PhotoSets[0].Photographer);
            Assert.Equal(3, data.PhotoSets[0].Photos.Count);
        }

        [Fact]
        public void ShouldCreatePhotoSets()
        {
            var files = new List<string> { "file1.jpg", "file2.jpg", "file3.jpg", "file4.jpg" };
            var captions = new List<string> { "Caption1", "Caption2", "Caption3", "Caption4" };
            var photographers = new List<string> { "Alan", null, null, "Paul" };

            var data = new ReportData(photographers, files, captions);

            Assert.Equal(2, data.PhotoSets.Count);
            Assert.Equal("Alan", data.PhotoSets[0].Photographer);
            Assert.Equal(3, data.PhotoSets[0].Photos.Count);
            Assert.Equal("Paul", data.PhotoSets[1].Photographer);
            Assert.Single(data.PhotoSets[1].Photos);
        }

        [Fact]
        public void ValidateShouldErrorIfDayAndNoParent()
        {
            var data = new ReportData
            {
                Id = "walk_2021_02",
                Title = "Walk Title",
                Date = DateTime.Today,
                SubjectType = "Day"
            };

            var ex = Assert.Throws<ArgumentException>(() => data.Validate());
            Assert.Equal("You must enter a Parent event", ex.Message);
        }
    }
}
