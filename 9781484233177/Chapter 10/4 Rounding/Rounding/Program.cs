using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding
{
    class Program
    {
        static void Main(string[] args)
        {
            // For simplicity, inputs are fixed in program
            // Some amounts, e.g. after commission calculations, cent fractions are possible
            double amount1 = 1234.567;
            double amount2 = 9.876;

            // Displaying inputs (original values)
            Console.WriteLine("First amount (original value): " + amount1);
            Console.WriteLine("Second amount (original value): " + amount2);
            Console.WriteLine();

            // Rounding just for output
            Console.WriteLine("First amount displayed with cent precision: " + amount1.ToString("N2"));
            Console.WriteLine("Second amount displayed with cent precision: " + amount2.ToString("N2"));
            Console.WriteLine();

            // Rounding for further calculations + informative output
            double roundedAmount1 = Math.Round(amount1, 2); // 2 = two decimal places
            double roundedAmount2 = Math.Round(amount2, 2);

            Console.WriteLine("First amount rounded to cents: " + roundedAmount1);
            Console.WriteLine("Second amount rounded to cents: " + roundedAmount2);
            Console.WriteLine();

            // Calculations
            double sumOfOriginalAmounts = amount1 + amount2;
            double sumOfRoundedAmounts = roundedAmount1 + roundedAmount2;

            // Calculation outputs
            Console.WriteLine("Sum of original amounts: " + sumOfOriginalAmounts.ToString("N2"));
            Console.WriteLine("Sum of rounded amounts: " + sumOfRoundedAmounts.ToString("N2"));
            Console.WriteLine("On invoice, we need sum of rounded amounts");

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
