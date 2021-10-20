using Xunit;

namespace WalkPageGen.Tests
{
    public class SheetServiceTests
    {
        [Fact]
        public void SheetServiceShouldReturnData()
        {
            var applicationName = "Walk Page Generator Tests";
            var spreadSheetId = "1BxiMVs0XRA5nFMdKvBdBZjgmUUqptlbs74OgvE2upms";
            var range = "Class Data!A2:E";

            var results = new SheetService(applicationName, spreadSheetId).GetData(range);

            Assert.Equal(30, results.Count);
            Assert.Equal(5, results[0].Count);
        }
    }
}
