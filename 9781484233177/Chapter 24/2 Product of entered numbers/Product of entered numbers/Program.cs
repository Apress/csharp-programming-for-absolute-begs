using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_of_entered_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Preparations
            double product = 1;
            int number;

            // Entering numbers until zero
            do
            {
                // Input
                Console.Write("Enter a number (0 = end): ");
                string input = Console.ReadLine();
                number = Convert.ToInt32(input);

                // Accumulating in intermediate product (but not the last zero!)
                if (number != 0)
                {
                    product *= number;
                }

            } while (number != 0);

            // Output
            Console.WriteLine("Product of entered numbers (excluding zero) is: " + product.ToString("N0"));

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
