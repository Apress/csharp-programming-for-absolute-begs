using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Further_compound_assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            // With subtraction
            number -= 5; // same as number = number - 5;
            Console.WriteLine("After decrease by 5: " + number);

            // With multiplication
            number *= 10; // same as number = number * 10;
            Console.WriteLine("Ten times greater: " + number);

            // With division
            number /= 2; // same as number = number / 2;
            Console.WriteLine("Decreased to one half: " + number);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
