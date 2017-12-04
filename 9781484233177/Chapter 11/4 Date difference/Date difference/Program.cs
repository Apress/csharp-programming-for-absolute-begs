using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter your date of birth: ");
            string input = Console.ReadLine();
            DateTime dateOfBirth = Convert.ToDateTime(input);

            // Today
            DateTime today = DateTime.Today;

            // Date difference
            TimeSpan difference = today - dateOfBirth;
            int numberOfDays = difference.Days;

            // Output
            Console.WriteLine();
            Console.WriteLine("Today is: " + today.ToShortDateString());
            Console.WriteLine("The world likes you for this number of days: " + numberOfDays.ToString("N0"));

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
