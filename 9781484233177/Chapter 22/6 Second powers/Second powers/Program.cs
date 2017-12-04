using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_powers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output
            for (int number = 1; number <= 10; number++)
            {
                int secondPower = number * number;
                Console.WriteLine(number.ToString() + " " + secondPower.ToString());
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
