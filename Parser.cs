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
        public void DisplayTime(string time, string timezone){
            Console.WriteLine("The time in {0} is {1}", timezone, time);
            //The time in the UK is { time}
            //and the time in { timezone} is { converted time}
        }

        internal void DisplayTime(Tuple<string, string> timezone)
        {
            throw new NotImplementedException();
        }
    }
}
