using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Until_second_six
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random number generator
            Random randomNumbers = new Random();

            // Throwing until the second six is thrown
            int howManySixes = 0;
            do
            {
                // Actual throwing
                int thrown = randomNumbers.Next(1, 6 + 1);
                Console.WriteLine(thrown);

                // Counting sixes
                if (thrown == 6)
                {
                    howManySixes++;
                }
            } while (howManySixes < 2);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
