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

            TimeZoneInfo timeZoneInfo = null;

            //Loop through timeszones until find our timezone
            //Return offset for timezone
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
