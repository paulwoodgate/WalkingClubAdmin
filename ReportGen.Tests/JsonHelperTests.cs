using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ReportGen.Tests
{
    public class JsonHelperTests
    {
        [Fact]
        public void FindStringShouldReturnTheSpecifiedString()
        {
            const string json = "[{\"id\": \"walk-2023-01-01\"}]";

            var result = JsonHelper.FindString("\"id\"", json);

            Assert.Equal("walk-2023-01-01", result);
        }

        [Fact]
        public void FindStringShouldReturnNullIfKeyNotFound()
        {
            const string json = "[{\"id\": \"walk-2023-01-01\"}]";

            var result = JsonHelper.FindString("\"ids\"", json);

            Assert.Null(result);
        }

        [Fact]
        public void FindDateShouldReturnTheSpecifiedValue()
        {
            const string json = "[{\"date\": {\"$date\":\"2023-12-17T00:00:00Z\"},}]";

            var result = JsonHelper.FindDate("\"date\"", json);

            Assert.Equal(new DateTime(2023, 12, 17, 0, 0, 0, DateTimeKind.Local), result);
        }

        [Fact]
        public void FindDateShouldReturnNullIfKeyNotFound()
        {
            const string json = "[{\"date\": {\"$date\":\"2023-12-17T00:00:00Z\"},}]";

            var result = JsonHelper.FindDate("\"dates\"", json);

            Assert.Null(result);
        }

        [Fact]
        public void FindArrayShouldReturnAStringArray()
        {
            const string json = "[{\"report\": [\"Para 1\",\"Para 2\",\"Para 3\"]}]";

            var report = JsonHelper.FindArray("\"report\"", json);

            Assert.Equal(3, report.Length);
            Assert.Equal("Para 1", report[0]);
            Assert.Equal("Para 2", report[1]);
            Assert.Equal("Para 3", report[2]);
        }

        [Fact]
        public void FindArrayShouldReturnAStringArrayHandlingLineBreaks()
        {
            const string json = "[{   \"report\": [\r\n      \"It was a nice fresh winter morning for this walk. Unfortunately there were not many takers.\",\r\n      \"The route proceeds out to the west of Stilton through Folksworth as far as the medieval village of Papley.\",\r\n      \"One item of interest on the walk was the ruined church at Denton.\"\r\n    ]}]";

            var report = JsonHelper.FindArray("\"report\"", json);

            Assert.Equal(3, report.Length);
            Assert.Equal("It was a nice fresh winter morning for this walk. Unfortunately there were not many takers.", report[0]);
            Assert.Equal("The route proceeds out to the west of Stilton through Folksworth as far as the medieval village of Papley.", report[1]);
            Assert.Equal("One item of interest on the walk was the ruined church at Denton.", report[2]);
        }

        [Fact]
        public void CreatePhotoSetsShouldCreatePhotoSetWithSinglePhoto()
        {
            const string json = "[{\"photoSets\": [{\"photographer\": \"Jane\", \"photos\": [{\"file\":\"IMG_8717.jpg\", \"caption\": \"Outside the Motoring Museum in Bourton-on-the-Water\"}]}] ";

            var sets = JsonHelper.CreatePhotoSets(json);

            Assert.NotNull(sets);
            Assert.Single(sets);
            Assert.Equal("Jane", sets[0].Photographer);
            Assert.Single(sets[0].Photos);
        }

        [Fact]
        public void CreatePhotoSetsShouldReturnNullIfNoElement()
        {
            const string json = "[{\"report\": [\"Para 1\",\"Para 2\",\"Para 3\"]}]";

            var photoSets = JsonHelper.CreatePhotoSets(json);

            Assert.Empty(photoSets);
        }

        [Fact]
        public void CreatePhotoSetsShouldCreatePhotoSetWithMultiplePhotos()
        {
            const string json = "[{\"photoSets\": [{\"photographer\": \"Jane\", \"photos\": [          { \"file\": \"IMG_8717.jpg\", \"caption\": \"Outside the Motoring Museum in Bourton-on-the-Water\" },\r\n          { \"file\": \"IMG_8721.jpg\", \"caption\": \"Bourton-on-the-Water\" }]}] ";

            var sets = JsonHelper.CreatePhotoSets(json);

            Assert.NotNull(sets);
            Assert.Single(sets);
            Assert.Equal("Jane", sets[0].Photographer);
            Assert.Equal(2, sets[0].Photos.Count);
        }

    }
}
