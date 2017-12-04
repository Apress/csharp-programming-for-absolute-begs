using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_and_decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            // Increasing by 1 using INCREMENT OPERATOR
            number++; // same as number = number + 1;
            Console.WriteLine("Increased by 1: " + number);

            // Decreasing by 1 using DECREMENT OPERATOR
            number--; // same as number = number - 1;
            Console.WriteLine("Back again: " + number);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
