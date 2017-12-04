using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_date_is_today
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable of DateTime type, at first empty
            DateTime today;

            // Storing of today's date (without time component)
            today = DateTime.Today;

            // Output
            Console.WriteLine("Today is " + today);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
