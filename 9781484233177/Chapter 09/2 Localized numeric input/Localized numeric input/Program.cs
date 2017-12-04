using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace Localized_numeric_input
{
    class Program
    {
        static void Main(string[] args)
        {
            // AMERICAN    
            CultureInfo american = new CultureInfo("en-US");
            try
            {
                // Input 
                Console.Write("Enter American decimal number: ");
                string input = Console.ReadLine();
                double number = Convert.ToDouble(input, american);

                // Output
                Console.WriteLine("You have entered " + number);
            }
            catch (Exception)
            {
                // Error message
                Console.WriteLine("Incorrect input");
            }

            // CZECH
            CultureInfo czech = new CultureInfo("cs-CZ");
            try
            {
                // Input
                Console.Write("Enter Czech decimal number: ");
                string input = Console.ReadLine();
                double number = Convert.ToDouble(input, czech);

                // Output
                Console.WriteLine("You have entered " + number);
            }
            catch (Exception)
            {
                // Error message
                Console.WriteLine("Incorrect input");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
