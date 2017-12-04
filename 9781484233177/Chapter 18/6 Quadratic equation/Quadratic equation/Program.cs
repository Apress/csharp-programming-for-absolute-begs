using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            Console.Write("Enter a: ");
            string input = Console.ReadLine();
            double a = Convert.ToDouble(input);

            Console.Write("Enter b: ");
            string inputB = Console.ReadLine();
            double b = Convert.ToDouble(inputB);

            Console.Write("Enter c: ");
            string inputC = Console.ReadLine();
            double c = Convert.ToDouble(inputC);

            // Solving + output
            double d = b * b - 4 * a * c;
            if (d > 0)
            {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("The equation has two solutions:");
                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
            if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("The equation has a single solution: " + x);
            }
            if (d < 0)
            {
                Console.WriteLine("The equation does not have a solution");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
