using System;
using System.IO;
using Xunit;

namespace WalkPageGen.Tests
{
    public class OptionsTests
    {
        [Fact]
        public void SaveShouldCreateFIle()
        {
            var options = new Options
            {
                Year = 2021,
                GenerateHtml = true,
                GenerateJson = true,
                HtmlSourceFile = "source.html",
                HtmlOutputFile = "walks2021.html",
                JsonOutputFile = "walks2021.json"
            };
            const string filename = "optionsTest.json";
            var expectedPath = Path.Combine(Directory.GetCurrentDirectory(), filename);

            options.Save(filename);

            Assert.True(File.Exists(expectedPath), "The file has not been saved");

            var savedOptions = Options.Read(filename);
            Assert.Equal(options.Year, savedOptions.Year);
            Assert.Equal(options.GenerateHtml, savedOptions.GenerateHtml);
            Assert.Equal(options.GenerateJson, savedOptions.GenerateJson);
            Assert.Equal(options.HtmlSourceFile, savedOptions.HtmlSourceFile);
            Assert.Equal(options.HtmlOutputFile, savedOptions.HtmlOutputFile);
            Assert.Equal(options.JsonOutputFile, savedOptions.JsonOutputFile);

            if (File.Exists(expectedPath))
                File.Delete(expectedPath);
        }

        [Fact]
        public void ReadShouldReturnDefaultValuesIfFileDoesExist()
        {
            var options = Options.Read("nonexistentfile.json");
            var expectedYear = DateTime.Now.Year + 1;

            Assert.Equal(expectedYear, options.Year);
            Assert.True(options.GenerateHtml, "GenerateHtml == true");
            Assert.True(options.GenerateJson, "GenerateJson == true");
            Assert.Equal("source.html", options.HtmlSourceFile);
            Assert.Equal($"walks{expectedYear}.html", options.HtmlOutputFile);
            Assert.Equal($"walks{expectedYear}.json", options.JsonOutputFile);
        }

        [Fact]
        public void ValidateShouldErrorIfYearLessThan2000()
        {
            var options = new Options
            {
                Year = 1999,
                GenerateHtml = true,
                GenerateJson = false,
                HtmlSourceFile = "source.html",
                HtmlOutputFile = "htmloutput.html"
            };

            var ex = Assert.Throws<ArgumentException>(() => options.Validate());
            Assert.Equal("The year must not be before 2000", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfYearMoreThan5YearsAhead()
        {
            var options = new Options
            {
                Year = DateTime.Now.Year + 6,
                GenerateHtml = true,
                GenerateJson = false,
                HtmlSourceFile = "source.html",
                HtmlOutputFile = "htmloutput.html"
            };

            var ex = Assert.Throws<ArgumentException>(() => options.Validate());
            Assert.Equal($"The year must not be after {DateTime.Now.Year + 5}", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfNeitherCheckboxTrue()
        {
            var options = new Options
            {
                Year = DateTime.Now.Year,
                GenerateHtml = false,
                GenerateJson = false
            };

            var ex = Assert.Throws<ArgumentException>(() => options.Validate());
            Assert.Equal("At least one checkbox should be checked", ex.Message);
        }

        [Fact]
        public void ValidateShouldPassWithCorrectData()
        {
            var options = new Options
            {
                Year = 2021,
                GenerateHtml = true,
                GenerateJson = true,
                HtmlSourceFile = "appsettings.test.json",
                HtmlOutputFile = Path.Combine(Directory.GetCurrentDirectory(), "walks2021.html"),
                JsonOutputFile = Path.Combine(Directory.GetCurrentDirectory(), "walks2021.json")
            };

            options.Validate();

            Assert.True(true, "Error in validation");
        }

        [Fact]
        public void ValidateShouldErrorIfHtmlSourceMissing()
        {
            var options = new Options
            {
                Year = DateTime.Now.Year,
                GenerateHtml = true,
                GenerateJson = false,
                HtmlOutputFile = "walks2020.html"
            };

            var ex = Assert.Throws<ArgumentException>(() => options.Validate());
            Assert.Equal("The HTML source file does not exist", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfHtmlOutputFolderMissing()
        {
            var options = new Options
            {
                Year = DateTime.Now.Year,
                GenerateHtml = true,
                GenerateJson = false,
                HtmlSourceFile = "appsettings.test.json",
                HtmlOutputFile = "c:\\invalidFolder\\walks2020.html"
            };

            var ex = Assert.Throws<ArgumentException>(() => options.Validate());
            Assert.Equal("The folder \"c:\\invalidFolder\" does not exist", ex.Message);
        }
        [Fact]
        public void ValidateShouldErrorIfJsonOutputFolderMissing()
        {
            var options = new Options
            {
                Year = DateTime.Now.Year,
                GenerateHtml = false,
                GenerateJson = true,
                JsonOutputFile = "c:\\invalidFolder\\walks2020.json"
            };

            var ex = Assert.Throws<ArgumentException>(() => options.Validate());
            Assert.Equal("The folder \"c:\\invalidFolder\" does not exist", ex.Message);
        }
    }
}
