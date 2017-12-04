using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_two
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);

            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);

            // Evaluating
            int greater;
            if (number1 > number2)
            {
                greater = number1;
            }
            else
            {
                greater = number2;
            }

            // Output
            Console.WriteLine("Greater of entered numbers is: " + greater);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
