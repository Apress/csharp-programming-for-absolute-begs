using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Preparation
            int greatest = int.MinValue;

            // Input of ten numbers
            for (int order = 1; order <= 10; order++)
            {
                // Input
                Console.Write("Enter " + order.ToString() + ". number: ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);

                // Is it greater than the greatest so far?
                if (number > greatest)
                {
                    greatest = number;
                }
            }

            // Output
            Console.WriteLine("The greatest of entered numbers was: " + greatest.ToString());

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
