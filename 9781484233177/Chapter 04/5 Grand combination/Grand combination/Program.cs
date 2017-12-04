using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_combination
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data in variables
            string club1 = "FC Liverpool";
            string club2 = "Manchester United";
            int goals1 = 3;
            int goals2 = 2;

            // Output of match result
            Console.WriteLine(
                "Match " + club1 + " - " + club2 +
                " ended with result " +
                goals1 + ":" + goals2 + ".");

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
