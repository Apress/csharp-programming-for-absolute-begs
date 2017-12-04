using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();
            double number1 = Convert.ToDouble(input1);

            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();
            double number2 = Convert.ToDouble(input2);

            // Calculations 
            double sum = number1 + number2;
            double difference = number1 - number2;
            double product = number1 * number2;
            double quotient = number1 / number2;

            // Output
            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Difference is " + difference);
            Console.WriteLine("Product is " + product);
            Console.WriteLine("Quotient is " + quotient);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
