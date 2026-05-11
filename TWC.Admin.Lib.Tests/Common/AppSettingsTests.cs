using TWC.Admin.Lib.Common;
using Xunit;

namespace TWC.Admin.Lib.Tests.Common
{
    public class AppSettingsTests
    {
        [Fact]
        public void ReadFromFileShouldReturnObject()
        {
            var settings = AppSettings.ReadFromFile("common\\appsettings.test.json");

            Assert.Equal("Fred", settings.SheetId);
            Assert.Equal("Range", settings.Range);
            Assert.Equal("test.xlsx", settings.Workbook);
            Assert.True(settings.ReadFromGoogle, "ReadFromGoogle == true");
            Assert.Equal("./images", settings.ImagePath);
        }
    }
}
