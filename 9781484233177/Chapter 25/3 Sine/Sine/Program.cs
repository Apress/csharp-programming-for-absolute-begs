using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter an angle in degrees: ");
            string input = Console.ReadLine();
            double angle = Convert.ToInt32(input);

            // Converting to radians
            double x = Math.PI / 180 * angle;

            // Preparations
            double member;
            double sum = 0;
            double tinyValue = 1e-15;

            double sign = 1;
            double power = x;
            double factorial = 1;
            double multiplier = 1;

            // Sum of the series
            do
            {
                // Calculating current member of the series
                member = sign * power / factorial;

                // Appending to sum
                sum += member;

                // Preparing next step
                sign *= -1;

                multiplier++;
                factorial *= multiplier;
                multiplier++;
                factorial *= multiplier;

                power *= x * x;

            } while (Math.Abs(member) > tinyValue);


            // Output
            Console.WriteLine("Our value: " + sum.ToString());
            Console.WriteLine("Math.Sin:  " + Math.Sin(x).ToString());

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
