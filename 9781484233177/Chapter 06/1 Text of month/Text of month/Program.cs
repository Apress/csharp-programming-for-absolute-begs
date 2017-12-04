using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_of_month
{
    class Program
    {
        static void Main(string[] args)
        {
            // Today's date
            DateTime today = DateTime.Today;

            // Output
            Console.WriteLine("Today is " + today.ToLongDateString());

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
