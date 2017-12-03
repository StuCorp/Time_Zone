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
        public void DisplayTime(string time, string timezone, string converted_time){
            
            //The time in the UK is { time} and the time in { timezone} is { converted time}
            Console.WriteLine("The time in the UK is {0} and the time in {1} is {2}", time, timezone, converted_time); 
        }

        internal void DisplayTime(Tuple<string, string> timezone)
        {
            throw new NotImplementedException();
        }
    }
}
