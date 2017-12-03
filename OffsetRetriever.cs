using System;
using System.Collections.ObjectModel;

namespace Timezone
{
    public class OffsetRetriever
    {
        public TimeZoneInfo Find(String timezone)
        {
           //Retrieve the timezone data
            ReadOnlyCollection<TimeZoneInfo> zones = TimeZoneInfo.GetSystemTimeZones();

            TimeZoneInfo timeZoneInfo = zones[0];

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
