using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output
            for (double number = 9; number >= 0; number -= 0.9)
            {
                Console.WriteLine(number.ToString("N1"));
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
