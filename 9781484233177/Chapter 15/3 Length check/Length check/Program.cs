using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length_check
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            // Determining length
            int wordLength = word.Length;

            // Checking length
            if (wordLength <= 4)
            {
                Console.WriteLine("Word is short (at most 4 characters)");
            }
            else
            {
                Console.WriteLine("Word is long (more than 4 characters)");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
