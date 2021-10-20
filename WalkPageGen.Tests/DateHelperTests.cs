using System;
using Xunit;

namespace WalkPageGen.Tests
{
    public class DateHelperTests
    {
        [Theory]
        [InlineData("2019-01-01", "Tuesday 1st January")]
        [InlineData("2019-01-11", "Friday 11th January")]
        [InlineData("2019-01-21", "Monday 21st January")]
        [InlineData("2019-01-31", "Thursday 31st January")]
        public void DaysEndingInA1ShouldReturn1st(string baseDate, string expected)
        {
            var result = DateHelper.FormatWalkDate(DateTime.Parse(baseDate));

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2019-01-02", "Wednesday 2nd January")]
        [InlineData("2019-01-12", "Saturday 12th January")]
        [InlineData("2019-01-22", "Tuesday 22nd January")]
        public void DaysEndingInA2ShouldReturn2nd(string baseDate, string expected)
        {
            var result = DateHelper.FormatWalkDate(DateTime.Parse(baseDate));

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2019-01-03", "Thursday 3rd January")]
        [InlineData("2019-01-13", "Sunday 13th January")]
        [InlineData("2019-01-23", "Wednesday 23rd January")]
        public void DaysEndingInA3ShouldReturn3rd(string baseDate, string expected)
        {
            var result = DateHelper.FormatWalkDate(DateTime.Parse(baseDate));

            Assert.Equal(expected, result);
        }

        [Fact]
        public void DatesInSameMonthShouldOnlyReturnMonthOnSecond()
        {
            var result = DateHelper.FormatEventDates(DateTime.Parse("2019-02-08"), 2);

            Assert.Equal("Friday 8th to Sunday 10th February", result);
        }

        [Fact]
        public void DatesInDifferentMonthsShouldReturnMonthOnBoth()
        {
            var result = DateHelper.FormatEventDates(DateTime.Parse("2019-08-30"), 2);

            Assert.Equal("Friday 30th August to Sunday 1st September", result);
        }
    }
}
