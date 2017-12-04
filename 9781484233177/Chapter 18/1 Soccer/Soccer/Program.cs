using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer
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
                Console.WriteLine("Liverpool won.");
            }

            if (goalsLiverpool == goalsManchester)
            {
                Console.WriteLine("Tie.");
            }

            if (goalsLiverpool < goalsManchester)
            {
                Console.WriteLine("Manchester won.");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
