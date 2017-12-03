using Microsoft.VisualStudio.TestTools.UnitTesting;
using System; 
using System.Collections.ObjectModel;

namespace Timezone.Test
{
    [TestClass]
    public class TimezoneRetrieverTest
    {
        [TestMethod]
        public void Test_Find()
        {
            //Arrange
            String timezone = "Dundee";
            ReadOnlyCollection<TimeZoneInfo> zones = TimeZoneInfo.GetSystemTimeZones();
            TimeZoneInfo expected = zones[0]; 

            //Act
            TimeZoneInfo actual = Timezone.TimezoneRetriever.Find(timezone);
            

                //Assert
                Assert.AreEqual(expected, actual); 

        }
    }
}
