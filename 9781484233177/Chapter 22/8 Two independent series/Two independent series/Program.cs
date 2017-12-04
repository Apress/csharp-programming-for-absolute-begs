using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_independent_series
{
    class Program
    {
        static void Main(string[] args)
        {
            // Preparation
            int first = 111;

            // Output
            for (int second = 237; second <= 270; second += 3)
            {
                // Preparing first text
                string firstText = first >= 97 ?
                    first.ToString().PadLeft(3) : "   ";

                // Actual output
                Console.WriteLine(firstText + " " + second.ToString());

                // Changing x
                first -= 2;
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
