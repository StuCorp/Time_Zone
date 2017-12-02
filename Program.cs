using System;
//added to work with ReadOnlyCollection
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timezone
{
    class Program
    {        
        static void Main(string[] args)
        {
            Parser timeZoneParser = new Parser();
            using (Reader fileReader = new Reader())
            {
                List<Tuple<string, string>> lTimes = fileReader.Read();

                OffsetRetriever retrv = new OffsetRetriever();

                //Loop through each time-timezone pair 
                foreach (Tuple<string, string> entry in lTimes)
                {
                    //Catch errors from incorrectly formatted times
                    try {
                        //Convert String time to TimeSpan
                        TimeSpan time = TimeSpan.Parse(entry.Item1);
                        //Store timezone and retrieve its offset time from GMT
                        String timezone = entry.Item2;
                        TimeSpan offset = retrv.Find(timezone); 
                        //Difference between GMT time and timezone time
                        TimeSpan converted_time = time.Add(offset);

                        //Change converted_time calculation to below
                        //DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, cstZone);

                        //Print info to console
                        Console.WriteLine("The time in the UK is {0} and the time in {1} is {2}", time, timezone, converted_time); 
                    } 
                    catch(FormatException e){
                        //Log error
                        //Console.WriteLine("Error: {0}", e);
                    }

                }

                //TimeSpan currentGMT = DateTime.Now.TimeOfDay;
                //TimeSpan trimmedGMT = new TimeSpan(currentGMT.Hours, currentGMT.Minutes, currentGMT.Seconds);

            }

          

        }
    }
}
