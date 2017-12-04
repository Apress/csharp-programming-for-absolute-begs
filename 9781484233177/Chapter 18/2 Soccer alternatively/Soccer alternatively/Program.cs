using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer_alternatively
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            Console.Write("Goals scored by Liverpool: ");
            string inputLiverpool = Console.ReadLine();
            int goalsLiverpool = Convert.ToInt32(inputLiverpool);

            Console.Write("Goals scored by Manchester: ");
            string inputManchester = Console.ReadLine();
            int goalsManchester = Convert.ToInt32(inputManchester);

            // Evaluating
            if (goalsLiverpool > goalsManchester)
            {
                // Here we know Liverpool won. We can display the result.
                Console.WriteLine("Liverpool won.");
            }
            else
            {
                // Here we know Liverpool did not win. We will decide
                //   between tie and victorious Manchester
                if (goalsLiverpool == goalsManchester)
                {
                    Console.WriteLine("Tie.");
                }
                else
                {
                    Console.WriteLine("Manchester won.");
                }
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
