using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positive_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            // Evaluation
            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number is NOT positive");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
