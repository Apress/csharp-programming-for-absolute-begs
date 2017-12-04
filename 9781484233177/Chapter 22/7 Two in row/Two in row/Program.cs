using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_in_row
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output
            for (int number = 1; number <= 20; number++)
            {
                Console.Write(number);

                // What goes after the number depends on even/odd test
                if (number % 2 != 0)
                {
                    // Odd number, displaying space
                    Console.Write(" ");
                }
                else
                {
                    // Even number, new line
                    Console.WriteLine();
                }
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
