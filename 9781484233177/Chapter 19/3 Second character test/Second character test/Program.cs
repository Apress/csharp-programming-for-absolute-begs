using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_character_test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter product label: ");
            string label = Console.ReadLine();

            // Evaluating
            if (label.Length >= 2 && label.Substring(1, 1) == "X")
            {
                Console.WriteLine("Label is OK");
            }
            else
            {
                Console.WriteLine("Incorrect label");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
