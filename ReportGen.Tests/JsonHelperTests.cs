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
            const string json = "[{\"date\": { \"$date\": \"2023-12-17T00:00:00Z\" }}]";

            var result = JsonHelper.FindDate("\"date\"", json);

            Assert.Equal(new DateTime(2023, 12, 17, 0, 0, 0, DateTimeKind.Local), result);
        }

        [Fact]
        public void FindDateShouldReturnTheSpecifiedValueWithDifferentSpacing()
        {
            const string json = "[{\"date\": {\"$date\":\"2023-12-17T00:00:00Z\" }}]";

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

            var report = JsonHelper.FindArray("\"report\":", json);

            Assert.Equal(3, report.Length);
            Assert.Equal("Para 1", report[0]);
            Assert.Equal("Para 2", report[1]);
            Assert.Equal("Para 3", report[2]);
        }

        [Fact]
        public void FindArrayShouldHandleOtherChars()
        {
            const string json = "[{\r\n\t\"id\": \"walk-2024-01-01\",\r\n\t\"date\": {\"$date\":\"2024-01-01T00:00:00Z\"},\r\n\t\"year\": \"2024\",\r\n\t\"title\": \"Helpston\",\r\n\t\"subjectType\": \"Walk\",\r\n\t\"report\": [\"Fortunately, it stopped raining for this, the first walk of the year, although it was still very muddy in places – definitely one for gaiters.\",\"Nine of us met up in Helpston, the birth place of the poet John Clare in 1793. The house where he lived, apart from being a museum, opens as a tea shop on some days during the year. \",\"As we passed Simon’s Wood we came across a load of discarded bottles of hand sanitizer. We blamed the Chinese!\",\"From there we made our way southwards to Castor Hanglands Country Park, which was the most interesting part of the walk but also the muddiest.\",\"Just on from there we passed the entrance to Southey Woods, where although the car park was closed, there were lots of cars parked on the road verge. We did pass some people with dogs.\",\"Our return north included rather too much road walking, but at least that meant we weren’t tramping through mud.\",\"Fortunately, the Bluebell Inn was open and virtually empty for our post-walk drink.\"],\r\n\t\"reportBy\": \"Alan\",\r\n\t\"walkRating\": \"Nnot great but conveniently local\",\r\n\t\"coverPhoto\": \"walk010124~1.jpg\",\r\n\t\"photoSets\": [{\"photographer\": \"Alan\", \"photos\": [{\"file\": \"walk010124~1.jpg\", \"caption\": \"Tina points the way, as a slight navigational anomaly led us to crossing a ditch.\"}, {\"file\": \"walk010124~2.jpg\", \"caption\": \"It was a fine day.\"}, {\"file\": \"walk010124~3.jpg\", \"caption\": \"We stop for coffee.\"}, {\"file\": \"walk010124~4.jpg\", \"caption\": \"Belted Galloways at Hanglands.\"}]}]\r\n}]\r\n";

            var report = JsonHelper.FindArray("\"report\":", json);

            Assert.Equal(7, report.Length);
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
