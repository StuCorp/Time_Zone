using System;
using System.Collections.ObjectModel;

namespace Timezone
{
    public class TimezoneRetriever
    {
        public static TimeZoneInfo Find(String timezone)
        {
            //Retrieve the timezone data
            ReadOnlyCollection<TimeZoneInfo> zones = TimeZoneInfo.GetSystemTimeZones();

            //Set default timezone to be returned to null
            TimeZoneInfo timeZoneInfo = null;

            //Loop through timeszones until finding our 
            foreach (TimeZoneInfo zone in zones)
            {
                if (zone.Id.Contains(timezone))
                {
                    timeZoneInfo = zone;
                    break;
                }
            }
            return timeZoneInfo;

        }
    }
}
