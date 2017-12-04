using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_values
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two logical (Boolean) variables
            bool thePrettiestGirlLovesMe = true;
            bool iAmHungry = false;

            // Use exclamation mark to negate logical value
            bool iAmNotHungry = !iAmHungry;

            // Output
            Console.WriteLine("She loves me: " + thePrettiestGirlLovesMe);
            Console.WriteLine("I am hungry: " + iAmHungry);
            Console.WriteLine("I am not hungry: " + iAmNotHungry);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
