using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // IN CODE, decimal separator is always DOT regardless of computer language settings
            double piApproximately = 3.14;

            // Pi is already available in C#
            double piMorePrecisely = Math.PI;

            // Decimal numbers have always limited precision
            double notCompletelyOne = 0.999999999999999999;

            // Outputs
            Console.WriteLine("Pi value from our code: " + piApproximately);
            Console.WriteLine("Pi value from C#: " + piMorePrecisely);
            Console.WriteLine("This should not be exact one: " + notCompletelyOne);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
