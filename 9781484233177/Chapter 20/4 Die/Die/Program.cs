using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random number generator
            Random randomNumbers = new Random();

            // Output
            for (int count = 0; count < 20; count++)
            {
                int thrown = randomNumbers.Next(1, 6 + 1);
                Console.Write(thrown.ToString() + " ");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
