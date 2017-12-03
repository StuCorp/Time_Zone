using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timezone
{
    interface IParser
    {
        //Altered method signature to include converted_time 
        void DisplayTime(string time, string timezone, string converted_time);
    }
}
