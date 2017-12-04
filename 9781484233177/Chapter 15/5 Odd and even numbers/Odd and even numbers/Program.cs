using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_and_even_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            // Remainder calculation
            int remainderAfterDivisionByTwo = number % 2;

            // Evaluation 
            if (remainderAfterDivisionByTwo == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
