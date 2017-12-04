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
            // Pay special attention when mixing texts with numbers!
            Console.WriteLine(
@"Senior math test
==================

One and one is:");
            Console.WriteLine("a) " + 1 + 1);
            Console.WriteLine("b) " + (1 + 1));
            Console.WriteLine("c) " + "mostly fun");

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
