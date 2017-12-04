using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            Console.Write("Enter a: ");
            string inputA = Console.ReadLine();
            double a = Convert.ToDouble(inputA);

            Console.Write("Enter b: ");
            string inputB = Console.ReadLine();
            double b = Convert.ToDouble(inputB);

            // Solving the equation
            if (a != 0)
            {
                // a is non-zero, the equation has "normal" solution
                double solution = -b / a;
                Console.WriteLine("Solution is x=" + solution);
            }
            else
            {
                // a is zero, result depends on b
                if (b == 0)
                {
                    Console.WriteLine("The equation \"is solved\" by any x");
                }
                else
                {
                    Console.WriteLine("The equation does not have a solution");
                }
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
