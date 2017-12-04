using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output_of_all_entered_names
{
    class Program
    {
        static void Main(string[] args)
        {
            // Preparation
            string inSameOrder = "";
            string inReversedOrder = "";
            bool terminating;

            // Repeating until blank input
            do
            {
                // Input
                Console.Write("Enter person: ");
                string person = Console.ReadLine();

                // Processing input
                terminating = person.Trim() == "";
                if (!terminating)
                {
                    inSameOrder = inSameOrder + person + ", ";
                    inReversedOrder = person + ", " + inReversedOrder;
                }

            } while (!terminating);

            // Removing trailing comma and space
            if (inSameOrder.EndsWith(", "))
            {
                int numberOfCharacters = inSameOrder.Length;
                inSameOrder = inSameOrder.Remove(numberOfCharacters - 2);
            }
            if (inReversedOrder.EndsWith(", "))
            {
                int numberOfCharacters = inReversedOrder.Length;
                inReversedOrder = inReversedOrder.Remove(numberOfCharacters - 2);
            }

            // Output
            Console.WriteLine("Entered persons: " + inSameOrder);
            Console.WriteLine("In reversed order: " + inReversedOrder);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
