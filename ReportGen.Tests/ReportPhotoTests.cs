using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ReportGen.Tests
{
    public class ReportPhotoTests
    {
        [Fact]
        public void ToJsonShouldReturnObjectInJsonForm()
        {
            var photo = new ReportPhoto("Photo_1_1.jpg", "This is a caption");

            Assert.Equal($"{{\"filename\": \"{photo.Filename}\", \"caption\": \"{photo.Caption}\"}}", photo.ToJson());
        }
    }
}
