using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_complex_calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiplication has greater priority
            Console.WriteLine(1 + 2*3);

            // Forcing priority using parentheses
            Console.WriteLine((1 + 2)*3);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
