using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;



namespace Timezone
{
    class Reader : IReader, IDisposable
    {
        public List<Tuple<string, string>> Read()
        {
            List<Tuple<string, string>> lReturn = new List<Tuple<string, string>>();

           //Access Timezone.txt resource in assembly 
            var resourceName = "Timezone.Timezone.txt";
            var timezoneResStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);

            //Used SteamReader as FileReader was incompatible with resource stream 
            StreamReader reader = new StreamReader(timezoneResStream);
            string[] fileParts = reader.ReadToEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string part in fileParts)
            {
                string[] sLineParts = part.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Tuple<string, string> timeZone = new Tuple<string, string>(sLineParts.First(), sLineParts.Last());

                lReturn.Add(timeZone);
            }

            return lReturn;
        }
        public void Dispose()
        {
        }
    }
}
