using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_and_one
{
    class Program
    {
        static void Main(string[] args)
        {
            // Precalculation of result (into a variable)
            int sum = 1 + 1;

            // Output to the user
            Console.WriteLine(
@"Answer to Senior math test 
=========================

One and one is: " + sum);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
