using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations_with_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. SOLUTION
            // Values to be summed
            int firstNumber = 42;
            int secondNumber = 11;

            // Calculating
            int sum = firstNumber + secondNumber;

            // Output
            Console.WriteLine("Sum is: " + sum);

            // 2. SOLUTION
            // Declaring all variables at once
            int thirdNumber, fourthNumber, newSum;

            // Values to be summed
            thirdNumber = 42;
            fourthNumber = 11;

            // Calculating
            newSum = thirdNumber + fourthNumber;

            // Output
            Console.WriteLine("Calculated another way: " + newSum);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
