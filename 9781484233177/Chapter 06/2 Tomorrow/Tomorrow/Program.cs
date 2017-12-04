using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomorrow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Today's date
            DateTime today = DateTime.Today;

            // Tomorrow's date
            DateTime tomorrow = today.AddDays(1);

            // Output
            Console.WriteLine("Today is " + today.ToShortDateString() + ".");
            Console.WriteLine("I will start learning on " + tomorrow.ToShortDateString() + ".");

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
