using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Until_two_sixes_in_a_row
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random number generator
            Random randomNumbers = new Random();

            // Preparations
            int previous = 0;
            bool ending;

            // Throwing until two sixes in a row
            do
            {
                // Actually throwing
                int thrown = randomNumbers.Next(1, 6 + 1);
                Console.WriteLine(thrown);

                // Evaluating
                ending = thrown == 6 && previous == 6;

                // Preparing for next round of the loop
                previous = thrown;
            } while (!ending);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
