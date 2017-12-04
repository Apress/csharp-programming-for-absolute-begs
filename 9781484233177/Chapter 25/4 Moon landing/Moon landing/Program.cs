using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_landing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial values
            double h = 50, v = 8, mF = 35;

            // Preparation
            bool malfunction = false;

            // Repeating individual landing steps 
            while (h >= 0)
            {
                // Displaying current values
                string height   = "Height: " + h.ToString("N1");
                string velocity = "Velocity: " + v.ToString("N1");
                string fuel     = "Fuel: " + mF.ToString("N1");
                Console.WriteLine(height + "  " + velocity + "  " + fuel);

                // Input
                Console.Write("Enter percentage of breaking (0-100): ");
                string input = Console.ReadLine();
                double percents = 0;
                try
                {
                    percents = Convert.ToDouble(input);
                    if (percents < 0 || percents > 100)
                    {
                        malfunction = true;
                    }
                }
                catch (Exception)
                {
                    malfunction = true;
                }
                if (malfunction)
                {
                    percents = 0;
                    Console.WriteLine("CONTROL MALFUNCTION!");
                }

                // Fuel check
                if (mF <= 0)
                {
                    percents = 0;
                    Console.WriteLine("NO FUEL!");
                }

                // Calculating new values
                double F = 360 * percents;
                double a = 1.62 - F / 8000;
                h -= v + a / 2;
                v += a;
                mF -= F / 3000;
                if (mF <= 0)
                {
                    mF = 0;
                }

                // Output of an empty line
                Console.WriteLine();

            } // End of a single landing step

            // Output
            Console.WriteLine("Landing velocity: " + v.ToString("N1"));
            string evaluation = v < 4 ?
                "Soft landing, congratulations!" :
                (v <= 8 ? "Hard landing." : "Houston, crew is lost...");
            Console.WriteLine(evaluation);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
