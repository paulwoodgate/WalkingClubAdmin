using System;
using Xunit;

namespace ReportGen.Tests
{
    public class ConvertOptionsTests
    {
        [Fact]
        public void ValidateShouldErrorIfNoOutputFolder()
        {
            var options = new ConvertOptions
            {
                ConvertFolder = true,
                FolderPath = "c:\\dev"
            };

            var ex = Assert.Throws<ArgumentException>(() => options.Validate());
            Assert.Equal("An output folder must be supplied", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfOutputFolderDoesNotExist()
        {
            var options = new ConvertOptions
            {
                ConvertFolder = true,
                OutputPath = "c:\\unknown",
                FolderPath = "c:\\dev"
            };

            var ex = Assert.Throws<ArgumentException>(() => options.Validate());
            Assert.Equal("The output folder \"c:\\unknown\" does not exist", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfFolderSelectedAndNoFolder()
        {
            var options = new ConvertOptions
            {
                ConvertFolder = true,
                OutputPath = "c:\\dev"
            };

            var ex = Assert.Throws<ArgumentException>(() => options.Validate());
            Assert.Equal("A source folder must be supplied when converting a folder", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfFolderSelectedFolderDoesNotExist()
        {
            var options = new ConvertOptions
            {
                ConvertFolder = true,
                OutputPath = "c:\\dev",
                FolderPath = "c:\\de"
            };

            var ex = Assert.Throws<ArgumentException>(() => options.Validate());
            Assert.Equal("The source folder \"c:\\de\" does not exist", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfFileSelectedAndNoFilename()
        {
            var options = new ConvertOptions
            {
                ConvertFolder = false,
                OutputPath = "c:\\dev"
            };

            var ex = Assert.Throws<ArgumentException>(() => options.Validate());
            Assert.Equal("A source file must be supplied when converting a file", ex.Message);
        }

        [Fact]
        public void ValidateShouldErrorIfFileSelectedFileDoesNotExist()
        {
            var options = new ConvertOptions
            {
                ConvertFolder = false,
                OutputPath = "c:\\dev",
                FileName = "c:\\dev\\missing.json"
            };

            var ex = Assert.Throws<ArgumentException>(() => options.Validate());
            Assert.Equal("The source file \"c:\\dev\\missing.json\" does not exist", ex.Message);
        }

        [Fact]
        public void ValidateShouldPassWithCorrectData()
        {
            var options = new ConvertOptions
            {
                ConvertFolder = false,
                FileName = "c:\\dev\\WalkingClubAdmin\\ReadMe.md",
                OutputPath = "c:\\dev\\twc-astro"
            };

            var ex = Record.Exception(() => options.Validate());
            Assert.Null(ex);
        }
    }
}
