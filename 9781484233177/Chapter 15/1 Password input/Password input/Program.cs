using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_input
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter password: ");
            string enteredPassword = Console.ReadLine();

            // Password check
            if (enteredPassword == "friend")
            {
                Console.WriteLine("Password is OK, please enter");
            }
            else
            {
                Console.WriteLine("Incorrect password");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
