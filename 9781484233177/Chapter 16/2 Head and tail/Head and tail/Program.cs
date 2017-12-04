using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_and_tail
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random number generator
            Random randomNumbers = new Random();

            // Random number 0/1 and its transformation
            int randomNumber = randomNumbers.Next(0, 1 + 1);
            if (randomNumber == 0)
            {
                Console.WriteLine("Head tossed");
            }
            else
            {
                Console.WriteLine("Tail tossed");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
