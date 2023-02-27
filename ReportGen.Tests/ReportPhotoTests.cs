using System;
using Xunit;

namespace ReportGen.Tests
{
    public class ReportPhotoTests
    {
        [Fact]
        public void ShouldErrorIfNoFilename()
        {
            var ex = Assert.Throws<ArgumentException>(() => new ReportPhoto(null, "This is a caption"));

            Assert.Equal("You must supply a filename", ex.Message);
        }

        [Fact]
        public void ShouldErrorIfBlankFilename()
        {
            var ex = Assert.Throws<ArgumentException>(() => new ReportPhoto("", "This is a caption"));

            Assert.Equal("You must supply a filename", ex.Message);
        }

        [Fact]
        public void ToJsonShouldReturnObjectInJsonForm()
        {
            var photo = new ReportPhoto("Photo_1_1.jpg", "This is a caption");

            Assert.Equal($"{{\"file\": \"{photo.Filename}\", \"caption\": \"{photo.Caption}\"}}", photo.ToJson());
        }

        [Fact]
        public void ToJsonShouldNotErrorIfNullCaption()
        {
            var photo = new ReportPhoto("photo_1_1.jpg", null);

            var json = photo.ToJson();

            Assert.NotNull(json);
        }
    }
}
