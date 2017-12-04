using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entering_password
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctPassword = "friend";

            bool ok; // the variable must be declared outside of the loop!
            do
            {
                // Input
                Console.Write("Enter password: ");
                string enteredPassword = Console.ReadLine();

                // Evaluating
                ok = enteredPassword == correctPassword;
            } while (!ok); // loop repeats when the condition holds

            Console.WriteLine("Come inside, please...");

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
