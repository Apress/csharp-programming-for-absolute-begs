using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_condition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Correct password
            string correctPassword = "friend";

            // Input
            Console.Write("Enter password: ");
            string enteredPassword = Console.ReadLine();

            // Password check
            if (enteredPassword != correctPassword)
            {
                Console.WriteLine("Incorrect password");
            }
            else
            {
                Console.WriteLine("Password is OK, please enter");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
