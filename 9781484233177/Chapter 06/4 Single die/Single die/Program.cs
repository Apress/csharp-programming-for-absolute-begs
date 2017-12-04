using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_die
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating random number generator object
            Random randomNumbers = new Random();

            // Repeatedly throwing a die 
            int number1 = randomNumbers.Next(1, 6 + 1);
            int number2 = randomNumbers.Next(1, 6 + 1);
            int number3 = randomNumbers.Next(1, 6 + 1);

            // Output
            Console.WriteLine("Thrown numbers: " +
                number1 + ", " +
                number2 + ", " +
                number3);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
