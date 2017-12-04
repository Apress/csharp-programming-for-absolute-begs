using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_braces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            Console.Write("Enter a name: ");
            string name1 = Console.ReadLine();

            Console.Write("Enter another name: ");
            string name2 = Console.ReadLine();

            // Converting to small letters
            string name1inSmall = name1.ToLower();
            string name2inSmall = name2.ToLower();

            // Evaluating 
            // BRANCHES NOT DELIMITED BY BRACES (CURLY BRACKETS¨)
            if (name1inSmall == name2inSmall)
                Console.WriteLine("You have entered the same names");
            else
                Console.WriteLine("You have entered different names");

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
