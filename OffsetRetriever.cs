using System;
using System.Collections.ObjectModel;

namespace Timezone
{
    public class OffsetRetriever
    {
        public TimeSpan Find(String timezone)
        {
           //Retrieve the timezone data
            ReadOnlyCollection<TimeZoneInfo> zones = TimeZoneInfo.GetSystemTimeZones();

            TimeSpan offset;

            //Loop through timeszones until find our timezone
            //Return offset for timezone
            foreach (TimeZoneInfo zone in zones)
            {
                if (zone.Id.Contains(timezone))
                {
                    offset = zone.BaseUtcOffset;
                    break; 
                }
            }
            return offset; 

        }
    }
}
