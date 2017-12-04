using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Every_other_alternatively
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output
            for (int line = 1; line <= 10; line++)
            {
                int displayedNumber = 2 * line;
                Console.WriteLine(displayedNumber);
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
