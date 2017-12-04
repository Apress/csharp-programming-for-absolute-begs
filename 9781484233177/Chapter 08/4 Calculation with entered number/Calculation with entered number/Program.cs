using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation_with_entered_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompting the user
            Console.Write("Enter year of your birth: ");

            // Reading line of text 
            string input = Console.ReadLine();

            // CONVERING TO NUMBER (of entered text)
            int yearOfBirth = Convert.ToInt32(input);

            // Finding this year
            DateTime today = DateTime.Today;
            int thisYear = today.Year;

            // Calculating age
            int age = thisYear - yearOfBirth;

            // Outputting the result
            Console.WriteLine("This year you are/will be: " + age);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
