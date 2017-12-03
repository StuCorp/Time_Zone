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

                //Loop through each time-timezone pair 
                foreach (Tuple<string, string> entry in lTimes)
                {
                    //Catch errors from incorrectly formatted times 
                    try {
                      //Retrieve timezone  
                        TimeZoneInfo timeZoneInfo = TimezoneRetriever.Find(entry.Item2);
                                      
                       //If timezone found, find converted time and display 
                        if (timeZoneInfo != null)
                        {
                            DateTime time = DateTime.Parse(entry.Item1);
                            String converted_time = (TimeZoneInfo.ConvertTimeFromUtc(time, timeZoneInfo)).ToString("HH:mm");
                            //Print info to console
                            timeZoneParser.DisplayTime(entry.Item1, entry.Item2, converted_time);
                        }
                        else {
                            //If no timezone found
                            Console.WriteLine("Error: Timezone not found");
                        }
                    } 
                    catch(FormatException){
                        //If time value is not valid 
                        Console.WriteLine("Error: invalid Time value");
                    }

                }

            }

          

        }
    }
}
