using System;
using Xunit;

namespace ReportGen.Tests
{
    public class ReportDataTests
    {
        [Fact]
        public void ShouldInitialiseCaptionsList()
        {
            var data = new ReportData();

            Assert.NotNull(data.Captions);
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
