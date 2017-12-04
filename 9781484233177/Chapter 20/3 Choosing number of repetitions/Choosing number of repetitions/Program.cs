using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choosing_number_of_repetitions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter number of repetitions: ");
            string input = Console.ReadLine();
            int howManyTimes = Convert.ToInt32(input);

            // Output
            for (int count = 0; count < howManyTimes; count++)
            {
                Console.WriteLine("I will start learning tomorrow.");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
