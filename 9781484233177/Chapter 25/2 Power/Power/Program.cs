using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            Console.Write("Enter x (number to be raised): ");
            string inputX = Console.ReadLine();
            double x = Convert.ToDouble(inputX);

            Console.Write("Enter n (power): ");
            string inputN = Console.ReadLine();
            int n = Convert.ToInt32(inputN);

            // Calculating
            double result = 1;
            for (int count = 0; count < n; count++)
            {
                result *= x;
            }

            // Output
            Console.WriteLine("x^n=" + result.ToString());

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
