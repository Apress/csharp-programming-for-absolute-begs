using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choosing_text
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            Console.Write("Enter text to repeat: ");
            string textToRepeat = Console.ReadLine();

            Console.Write("Enter number of repetitions: ");
            string input = Console.ReadLine();
            int howManyTimes = Convert.ToInt32(input);

            // Output
            for (int count = 0; count < howManyTimes; count++)
            {
                Console.WriteLine(textToRepeat);
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
