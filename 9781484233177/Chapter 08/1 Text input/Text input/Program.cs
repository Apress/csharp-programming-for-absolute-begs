using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_input
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading single line of text (until user presses Enter key)
            string input = Console.ReadLine();

            // Outputting the input
            Console.WriteLine(input);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
