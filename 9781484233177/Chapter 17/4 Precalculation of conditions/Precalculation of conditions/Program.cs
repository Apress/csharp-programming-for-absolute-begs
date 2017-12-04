using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Precalculation_of_conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Correct values
            string correctUsername1 = "Orwell";
            string correctPassword1 = "Catalonia";

            string correctUsername2 = "Blair";
            string correctPassword2 = "1984";

            // Inputs
            Console.Write("User name: ");
            string enteredUsername = Console.ReadLine();

            Console.Write("Password: ");
            string enteredPassword = Console.ReadLine();

            // Evalulating
            bool user1ok = enteredUsername.ToLower() == correctUsername1.ToLower() &&
                           enteredPassword == correctPassword1;
            bool user2ok = enteredUsername.ToLower() == correctUsername2.ToLower() &&
                           enteredPassword == correctPassword2;
            if (user1ok || user2ok)
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
