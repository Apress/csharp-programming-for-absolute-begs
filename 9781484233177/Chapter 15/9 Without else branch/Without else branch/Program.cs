using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_else_branch
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
            int greater = number1;
            if (number2 > greater)
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
