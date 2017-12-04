using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input of angle
            Console.Write("Enter an angle in degrees: ");
            string input = Console.ReadLine();
            double angleInDegrees = Convert.ToDouble(input);

            // Calculation and output of sine value
            double angleInRadians = angleInDegrees * Math.PI / 180;
            double result = Math.Sin(angleInRadians);
            Console.WriteLine("Sine of the angle is: " + result);

            // Input of a positive number
            Console.Write("Enter a positive number: ");
            input = Console.ReadLine();
            double number = Convert.ToDouble(input);

            // Calculation and output of square root
            Console.WriteLine("Square root of the number is: " + Math.Sqrt(number));

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
