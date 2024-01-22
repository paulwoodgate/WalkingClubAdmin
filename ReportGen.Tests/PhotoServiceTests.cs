using Xunit;

namespace ReportGen.Tests
{
    public class PhotoServiceTests
    {
        [Fact]
        public void StripPathFromFilenameShouldStripPath()
        {
            var filename = PhotoService.StripPathFromFilename("https://www.thewalkingclub.co.uk/Reports/walk160521~2.jpg");

            Assert.Equal("walk160521~2.jpg", filename);
        }

        [Fact]
        public void StripPathFromFilenameShouldReturnFilenameIfNoPath()
        {
            var filename = PhotoService.StripPathFromFilename("walk160521~2.jpg");

            Assert.Equal("walk160521~2.jpg", filename);
        }

        [Fact]
        public void StripPathFromFilenameShouldHandleNulls()
        {
            var filename = PhotoService.StripPathFromFilename(null);

            Assert.Null(filename);
        }
    }
}
