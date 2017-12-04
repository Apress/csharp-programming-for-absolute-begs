using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As_long_as_six_is_being_thrown
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random number generator
            Random randomNumbers = new Random();

            // Throwing as long as we have six
            int thrown;
            do
            {
                thrown = randomNumbers.Next(1, 6 + 1);
                Console.WriteLine(thrown);
            } while (thrown == 6);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
