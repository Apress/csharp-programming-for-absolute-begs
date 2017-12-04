using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yes_or_no
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Do you love me? ");
            string input = Console.ReadLine();

            // Evaluating
            string inputInSmall = input.ToLower();
            if (inputInSmall == "yes" || inputInSmall == "no")
            {
                Console.WriteLine("OK.");
            }
            else
            {
                Console.WriteLine("Say it straight!");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
