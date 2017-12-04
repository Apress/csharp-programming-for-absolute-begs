using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_input
{
    class Program
    {
        static void Main(string[] args)
        {
            // Decimal input
            Console.Write("Enter a decimal number: ");
            string input = Console.ReadLine();
            double decimalNumber = Convert.ToDouble(input);

            // Repeating entered number to the output
            Console.WriteLine("You have entered number " + decimalNumber);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
