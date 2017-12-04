using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_greatest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Preparation
            int greatest = int.MinValue;
            int secondGreatest = int.MinValue;

            // Input of ten numbers
            for (int order = 1; order <= 10; order++)
            {
                // Input
                Console.Write("Enter " + order.ToString() + ". number: ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);

                // Is it greater than the greatest so far?
                if (number > greatest)
                {
                    // Moving so far greatest to the second place
                    secondGreatest = greatest;

                    // Entered number becomes the greatest so far
                    greatest = number;
                }
                else
                {
                    // We did not beat the greatest, will we beat the second greatest at least?
                    if (number > secondGreatest)
                    {
                        secondGreatest = number;
                    }
                }
            }

            // Output
            Console.WriteLine("The second greatest of entered numbers was: " + secondGreatest.ToString());

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
