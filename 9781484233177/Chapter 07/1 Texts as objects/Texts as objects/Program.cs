using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texts_as_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Some text to try things on
            string text = "This is the last day of our acquaintance";

            // What e.g. can be done with texts
            Console.WriteLine("Original text: " + text);
            Console.WriteLine("Number of characters: " + text.Length);
            Console.WriteLine("In uppercase: " + text.ToUpper());
            Console.WriteLine("Does it contain word \"last\"? " + text.Contains("last"));

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
