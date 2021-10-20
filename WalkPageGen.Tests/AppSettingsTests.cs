using Xunit;

namespace WalkPageGen.Tests
{
    public class AppSettingsTests
    {
        [Fact]
        public void ReadFromFileShouldReturnObject()
        {
            var settings = AppSettings.ReadFromFile("appsettings.test.json");

            Assert.Equal("Fred", settings.SheetId);
            Assert.Equal("Range", settings.Range);
            Assert.Equal("test.xlsx", settings.Workbook);
            Assert.True(settings.ReadFromGoogle, "ReadFromGoogle == true");
        }
    }
}
