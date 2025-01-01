using System;
using System.IO;
using Xunit;

namespace WalkPageGen.Tests
{
    public class OptionsTests
    {
        [Fact]
        public void SaveShouldCreateFile()
        {
            var options = new Options
            {
                Year = 2021,
                ExcelSourceFile = "source.xlsx",
                OutputFile = "walks2021.json",
                ReadFromGoogle = true
            };
            const string filename = "optionsTest.json";
            var expectedPath = Path.Combine(Directory.GetCurrentDirectory(), filename);

            options.Save(filename);

            Assert.True(File.Exists(expectedPath), "The file has not been saved");

            var savedOptions = Options.Read(filename);
            Assert.Equal(options.Year, savedOptions.Year);
            Assert.Equal(options.ReadFromGoogle, savedOptions.ReadFromGoogle);
            Assert.Equal(options.ExcelSourceFile, savedOptions.ExcelSourceFile);
            Assert.Equal(options.OutputFile, savedOptions.OutputFile);

            if (File.Exists(expectedPath))
                File.Delete(expectedPath);
        }

        [Fact]
        public void SaveShouldSaveMarkdownOptions()
        {
            var options = new Options
            {
                Year = 2023,
                CreateJson = false,
                CreateMarkdown = true,
                MarkdownFolder = "c:\\documents\\events"
            };
            const string filename = "optionsTest.json";

            options.Save(filename);
            var savedOptions = Options.Read(filename);

            Assert.False(savedOptions.CreateJson, "CreateJson");
            Assert.True(savedOptions.CreateMarkdown, "CreateMarkdown");
            Assert.Equal(options.MarkdownFolder, savedOptions.MarkdownFolder);
        }

        [Fact]
        public void ReadShouldReturnDefaultValuesIfFileDoesNotExist()
        {
            var options = Options.Read("nonexistentfile.json");
            var expectedYear = DateTime.Now.Year + 1;

            Assert.Equal(expectedYear, options.Year);
            Assert.True(options.ReadFromGoogle, "ReadFromGoogle == true");
            Assert.Equal("source.xlsx", options.ExcelSourceFile);
            Assert.Equal($"walks{expectedYear}.json", options.OutputFile);
        }

        [Fact]
        public void ValidateShouldErrorIfYearLessThan2000()
        {
            var options = new Options
            {
                Year = 1999,
                ReadFromGoogle = true,
                OutputFile = "output.json"
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
                ReadFromGoogle = true,
                OutputFile = "output.json"
            };

            var ex = Assert.Throws<ArgumentException>(() => options.Validate());
            Assert.Equal($"The year must not be after {DateTime.Now.Year + 5}", ex.Message);
        }

        [Fact]
        public void ValidateShouldPassWithCorrectData()
        {
            var options = new Options
            {
                Year = DateTime.Today.Date.Year,
                ReadFromGoogle = true,
                CreateJson = true,
                ExcelSourceFile = "source.xlsx",
                OutputFile = Path.Combine(Directory.GetCurrentDirectory(), "walks2021.json")
            };

            options.Validate();

            Assert.True(true, "Error in validation");
        }

        [Fact]
        public void ValidateShouldErrorIfExcelSourceMissingAndReadingFromExcel()
        {
            var options = new Options
            {
                Year = DateTime.Now.Year,
                ReadFromGoogle = false,
                OutputFile = "walks2020.json"
            };

            var ex = Assert.Throws<ArgumentException>(() => options.Validate());
            Assert.Equal("The Excel source file does not exist", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfOutputFolderMissing()
        {
            var options = new Options
            {
                Year = DateTime.Now.Year,
                ReadFromGoogle = true,
                CreateJson = true,
                OutputFile = "c:\\invalidFolder\\walks2020.html"
            };

            var ex = Assert.Throws<ArgumentException>(() => options.Validate());
            Assert.Equal("The folder \"c:\\invalidFolder\" does not exist", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfMarkdownFolderDoesNotExist()
        {
            var options = new Options
            {
                Year = DateTime.Now.Year,
                ReadFromGoogle = true,
                CreateMarkdown = true,
                CreateJson = false,
                MarkdownFolder = "c:\\invalidFolder"
            };

            var ex = Assert.Throws<ArgumentException>(() => options.Validate());
            Assert.Equal("The folder \"c:\\invalidFolder\" does not exist", ex.Message);
        }
    }
}
