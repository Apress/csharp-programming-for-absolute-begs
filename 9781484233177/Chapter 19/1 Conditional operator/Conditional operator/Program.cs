using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random number generator
            Random randomNumbers = new Random();

            // Random number 0/1 and its transformation
            int randomNumber = randomNumbers.Next(0, 1 + 1);
            string message = randomNumber == 0 ? "Head tossed" : "Tail tossed";
            Console.WriteLine(message);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
