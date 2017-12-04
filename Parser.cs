using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timezone
{
    class Parser : IParser
    {
        //adding implementation of DisplayTime as reqd by IParser interface
        public void DisplayTime(string time, string timezone, string converted_time)
        {

            //The time in the UK is { time} and the time in { timezone} is { converted time}
            Console.WriteLine("The time in the UK is {0} and the time in {1} is {2}", time, timezone, converted_time);
        }

        internal void DisplayTime(Tuple<string, string> timezone)
        {
            //Lookup timezone  
            TimeZoneInfo timeZoneInfo = TimezoneRetriever.Find(timezone.Item2);

            //If timezone found, calculate converted time and display 
            if (timeZoneInfo != null)
            {
                //Try to parse time - catch resultant errors 
                try
                {
                    DateTime time = DateTime.Parse(timezone.Item1);
                    String converted_time = (TimeZoneInfo.ConvertTimeFromUtc(time, timeZoneInfo)).ToString("HH:mm");
                    //Print info to console
                    Console.WriteLine("The time in the UK is {0} and the time in {1} is {2}", timezone.Item1, timezone.Item2, converted_time);

                }
                catch (FormatException)
                {
                    //If time value is not valid 
                    Console.WriteLine("Error: invalid Time value");
                }
            }
            else
            {
                //If no timezone found
                Console.WriteLine("Error: Timezone not found");
            }

        }
    }
}
