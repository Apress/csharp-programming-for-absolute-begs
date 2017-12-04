using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waiting_for_descend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Preparations
            int previous = int.MinValue;
            bool ok;

            // Repeating until descend
            do
            {
                // Input
                Console.Write("Enter a value (number): ");
                string input = Console.ReadLine();
                int value = Convert.ToInt32(input);

                // Evaluating
                ok = value >= previous; // ok = still not descending

                // Storing for the next round of the loop
                previous = value;
            } while (ok);

            // Message to the user
            Console.WriteLine("Descend detected...");

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
