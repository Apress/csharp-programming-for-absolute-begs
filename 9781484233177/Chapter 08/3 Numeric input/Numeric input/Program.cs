using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeric_input
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompting the user
            Console.Write("How old are you? ");

            // Reading line of text
            string input = Console.ReadLine();

            // CONVERTING TO NUMBER (of entered text)
            int enteredNumber = Convert.ToInt32(input);

            // Output of entered number
            Console.WriteLine("Your age: " + enteredNumber);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
