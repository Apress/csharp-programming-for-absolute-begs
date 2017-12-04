using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better_input
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hinting user what we want from her
            Console.Write("Enter a sentence (and press Enter): ");

            // Reading line of text 
            string input = Console.ReadLine();

            // Repeating to the output
            Console.WriteLine("You have entered: " + input);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
