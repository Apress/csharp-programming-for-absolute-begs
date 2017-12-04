using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_check
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter a grade: ");
            string input = Console.ReadLine();
            int grade = Convert.ToInt32(input);

            // Evaluating
            if (grade == 1 ||
                grade == 2 ||
                grade == 3 ||
                grade == 4 ||
                grade == 5)
            {
                Console.WriteLine("Input OK.");
            }
            else
            {
                Console.WriteLine("Incorrect input.");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
