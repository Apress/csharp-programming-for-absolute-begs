using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Username_and_password
{
    class Program
    {
        static void Main(string[] args)
        {
            // Correct values
            string correctUsername = "Orwell";
            string correctPassword = "Catalonia";

            // Inputs
            Console.Write("User name: ");
            string enteredUserName = Console.ReadLine();

            Console.Write("Password: ");
            string enteredPassword = Console.ReadLine();

            // Evaluating
            if (enteredUserName.ToLower() == correctUsername.ToLower() &&
                enteredPassword == correctPassword)
            {
                Console.WriteLine("Thanks for your books!");
            }
            else
            {
                Console.WriteLine("Could not log you in.");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
