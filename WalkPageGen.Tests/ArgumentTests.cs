using System;
using Xunit;

namespace WalkPageGen.Tests
{
    public class ArgumentTests
    {
        [Fact]
        public void FormatShouldErrorIfLessThan2Args()
        {
            var args = new string[] { "1" };
            Exception ex = Assert.Throws<ArgumentException>(() => Arguments.Format(args));

            Assert.Equal("You must pass 2 arguments to the generator, the year and the name of the file to be created", ex.Message);
        }

        [Fact]
        public void FormatShouldErrorIfMoreThan2Args()
        {
            var args = new string[] { "1", "2", "3" };
            Exception ex = Assert.Throws<ArgumentException>(() => Arguments.Format(args));

            Assert.Equal("You must pass 2 arguments to the generator, the year and the name of the file to be created", ex.Message);
        }

        [Fact]
        public void FormatShouldErrorIfFirstArgIsNotANumber()
        {
            var args = new string[] { "First", "Second" };
            Exception ex = Assert.Throws<ArgumentException>(() => Arguments.Format(args));

            Assert.Equal("The first argument must be numeric", ex.Message);
        }

        [Fact]
        public void FormatShouldErrorIfYearBefore2017()
        {
            var args = new string[] { "2016", "Second" };
            Exception ex = Assert.Throws<ArgumentException>(() => Arguments.Format(args));

            Assert.Equal("The year must not be before 2017", ex.Message);
        }

        [Fact]
        public void FormatShouldErrorIfYearAfterNextYear()
        {
            var args = new string[] { (DateTime.Now.Year + 2).ToString(), "Second" };
            Exception ex = Assert.Throws<ArgumentException>(() => Arguments.Format(args));

            Assert.Equal("The year must not be after next year", ex.Message);
        }

        [Fact]
        public void FormatShouldReturnNewArgumentObject()
        {
            int year = 2017;
            var args = new string[] { year.ToString(), "WalksPage.html" };
            var arguments = Arguments.Format(args);

            Assert.NotNull(arguments);
            Assert.Equal(year, arguments.Year);
            Assert.Equal("WalksPage.html", arguments.Filename);
        }
    }
}
