using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ten_more
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number input
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            // Calculating 
            int result = number + 10;

            // Displaying the result
            Console.WriteLine("Number greater by ten: " + result);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
