using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_division
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            Console.Write("Enter 1. whole number (dividend): ");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);

            Console.Write("Enter 2. whole number (divisor): ");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);

            // Integer calculations
            int integerQuotient = number1 / number2;
            int remainder = number1 % number2;

            // "Normal" calculations
            double number1double = number1;
            double number2double = number2;
            double normalQuotient = number1double / number2double;

            // Alternatively
            double normalQuotientAlternatively = (double)number1 / (double)number2;

            // Outputs
            Console.WriteLine("-----------------");
            Console.WriteLine("Integer quotient: " + integerQuotient +
                " with remainder " + remainder);
            Console.WriteLine("\"Normal\" quotient : " + normalQuotient);
            Console.WriteLine("\"Normal\" quotient (alternatively): " + normalQuotientAlternatively);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
