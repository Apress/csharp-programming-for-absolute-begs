using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadline_check
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter order deadline: ");
            string input = Console.ReadLine();
            DateTime enteredDeadline = Convert.ToDateTime(input);

            // Checking entered value
            DateTime today = DateTime.Today;
            if (enteredDeadline < today)
            {
                Console.WriteLine("Error! You have entered date in the past.");
            }
            else
            {
                Console.WriteLine("Deadline accepted.");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
