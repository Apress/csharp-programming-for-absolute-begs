using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_time_is_it
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable of DateTime type, at first empty
            DateTime now;

            // Storing of current date and time into our variable
            now = DateTime.Now;

            // Output
            Console.WriteLine("Now is " + now);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
