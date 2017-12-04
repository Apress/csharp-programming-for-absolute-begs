using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specific_day
{
    class Program
    {
        static void Main(string[] args)
        {
            // A specific date
            DateTime overlordDday = new DateTime(1944, 6, 6);

            // Output
            Console.WriteLine("D-Day (Overlord operation): " +
                              overlordDday.ToLongDateString() + ".");

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
