using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_text_join
{
    class Program
    {
        static void Main(string[] args)
        {
            // Preparation - variables to accumulate intermediate results
            string inOriginalOrder = "";
            string inReversedOrder = "";

            // Input of the first person
            Console.Write("Enter first person: ");
            string person = Console.ReadLine();

            // Appending the first person to intermediate result
            inOriginalOrder += person + Environment.NewLine;
            inReversedOrder = person + Environment.NewLine + inReversedOrder;

            // Input of the second person
            Console.Write("Enter second person: ");
            person = Console.ReadLine();

            // Appending the second person to intermediate result
            inOriginalOrder += person + Environment.NewLine;
            inReversedOrder = person + Environment.NewLine + inReversedOrder;

            // Input of the third person
            Console.Write("Enter third person: ");
            person = Console.ReadLine();

            // Appending the third person to intermediate result
            inOriginalOrder += person + Environment.NewLine;
            inReversedOrder = person + Environment.NewLine + inReversedOrder;

            // Output
            Console.WriteLine();
            Console.WriteLine("Entered persons");
            Console.WriteLine("---------------");
            Console.WriteLine(inOriginalOrder);

            Console.WriteLine("In reversed order");
            Console.WriteLine("-----------------");
            Console.WriteLine(inReversedOrder);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
