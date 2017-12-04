
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow_treatment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0. Preparation
            int million = 1000000;

            // 1. Crash at least, we do not 
            //    definitely want a nonsense
            Console.WriteLine("1. calculation");
            try
            {
                long result = million * million;
                Console.WriteLine("Million times million:" + result);
            }
            catch (Exception)
            {
                Console.WriteLine("I cannot calculate this.");
            }

            // 2. Correct calculation of a big value
            Console.WriteLine("2. calculation");
            long millionInLong = million;
            long correctResult = millionInLong * millionInLong;
            Console.WriteLine("Million times million: " + correctResult.ToString("N0"));

            // 3. Alternative calculation of a big valule
            Console.WriteLine("3. calculation");
            long correctResultAlternatively = (long)million * (long)million;
            Console.WriteLine("Million times million: " + correctResultAlternatively.ToString("N0"));

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
