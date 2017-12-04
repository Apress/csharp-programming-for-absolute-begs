using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_entered_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Preparations
            int sum = 0;
            int number;

            // Entering numbers until zero
            do
            {
                // Input
                Console.Write("Enter a number (0 = end): ");
                string input = Console.ReadLine();
                number = Convert.ToInt32(input);

                // Adding to intermediate sum
                sum += number;

            } while (number != 0);

            // Output
            Console.WriteLine("Sum of entered numbers is: " + sum.ToString());

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
