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
                    timeZoneParser.DisplayTime(entry); 
               
                }
            }
        }
    }
}

