using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Further_rounding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter (decimal) amount in dollars: ");
            string input = Console.ReadLine();
            double amount = Convert.ToDouble(input);

            // To dollars
            double nearest    = Math.Round(amount);
            double alwaysDown = Math.Floor(amount);
            double alwaysUp   = Math.Ceiling(amount);

            Console.WriteLine();
            Console.WriteLine("To dollars");
            Console.WriteLine("----------");
            Console.WriteLine("Nearest    : " + nearest);
            Console.WriteLine("Always down: " + alwaysDown);
            Console.WriteLine("Always up  : " + alwaysUp);

            // To cents
            nearest    = Math.Round(amount, 2);
            alwaysDown = Math.Floor(100 * amount) / 100;
            alwaysUp   = Math.Ceiling(100 * amount) / 100;

            Console.WriteLine();
            Console.WriteLine("To cents");
            Console.WriteLine("--------");
            Console.WriteLine("Nearest    : " + nearest);
            Console.WriteLine("Always down: " + alwaysDown);
            Console.WriteLine("Always up  : " + alwaysUp);

            // To hundreds of dollars
            nearest    = 100 * Math.Round(amount / 100);
            alwaysDown = 100 * Math.Floor(amount / 100);
            alwaysUp   = 100 * Math.Ceiling(amount / 100);

            Console.WriteLine();
            Console.WriteLine("To hundreds of dollars");
            Console.WriteLine("----------------------");
            Console.WriteLine("Nearest    : " + nearest);
            Console.WriteLine("Always down: " + alwaysDown);
            Console.WriteLine("Always up  : " + alwaysUp);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
