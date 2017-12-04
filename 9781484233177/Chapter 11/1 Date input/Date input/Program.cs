using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_input
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Text input of date
                Console.Write("Enter date: ");
                string input = Console.ReadLine();

                // Conversion to DateTime object
                DateTime enteredDate = Convert.ToDateTime(input);

                // Some calculations
                DateTime followingDay = enteredDate.AddDays(1);
                DateTime previousDay  = enteredDate.AddDays(-1);

                // Outputs
                Console.WriteLine("Entered day  : " + enteredDate.ToLongDateString());
                Console.WriteLine("Following day: " + followingDay.ToLongDateString());
                Console.WriteLine("Previous day : " + previousDay.ToLongDateString());
            }
            catch (Exception)
            {
                // Treating incorrect input
                Console.WriteLine("Incorrect input");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
