using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace Localized_output
{
    class Program
    {
        static void Main(string[] args)
        {
            // Whole and decimal number
            int wholeNumber = 1234567;
            double decimalNumber = 1234567.89;

            // Localization objects
            CultureInfo czech    = new CultureInfo("cs-CZ");
            CultureInfo american = new CultureInfo("en-US");

            // Localized output
            Console.WriteLine("Whole number - Czech: "    + wholeNumber.ToString("N0", czech));
            Console.WriteLine("Whole number - American: " + wholeNumber.ToString("N0", american));

            Console.WriteLine("Decimal number - Czech: "    + decimalNumber.ToString("N2", czech));
            Console.WriteLine("Decimal number - American: " + decimalNumber.ToString("N2", american));

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
