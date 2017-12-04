using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_of_three_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            Console.Write("Enter 1. number: ");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);

            Console.Write("Enter 2. number: ");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);

            Console.Write("Enter 3. number: ");
            string input3 = Console.ReadLine();
            int number3 = Convert.ToInt32(input3);

            // At the beginning, we set 1st number as minimum
            int minimum = number1;

            // Is not 2nd number less than present minimum?
            if (number2 < minimum)
            {
                minimum = number2;
            }

            // Is not 3rd number less than present minimum?
            if (number3 < minimum)
            {
                minimum = number3;
            }

            // Output
            Console.WriteLine("The least of entered numbers is " + minimum);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
