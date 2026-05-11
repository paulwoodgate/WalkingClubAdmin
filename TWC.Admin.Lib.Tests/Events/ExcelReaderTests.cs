using Xunit;
using TWC.Admin.Lib.Events;

namespace TWC.Admin.Lib.Tests.Events
{
    public class ExcelReaderTests
    {
        const string filename = "Events\\Test Data\\ExcelReaderTest.xlsx";

        [Fact]
        public void GetColumnHeadersShouldReturnThreeValues()
        {
            var reader = new ExcelReader(filename, "Sheet1");

            var headings = reader.GetColumnHeaders();

            Assert.Equal(3, headings.Count);
            Assert.Equal("Text Column", headings[0]);
            Assert.Equal("Number Column", headings[1]);
            Assert.Equal("Date Column", headings[2]);
        }

        [Fact]
        public void ReadCellsShouldReturnListOfLists()
        {
            var reader = new ExcelReader(filename, "Sheet1");

            var values = reader.ReadRangeValues("A2:C4");

            Assert.Equal(3, values.Count);
            Assert.Equal(3, values[0].Count);
            Assert.Equal(3, values[1].Count);
            Assert.Equal(3, values[2].Count);
        }
    }
}
