using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiplying million by million
            int million = 1000000;
            int result = million * million;
            long resultInLong = million * million;

            // Outputs
            Console.WriteLine("Million times million: " + result);
            Console.WriteLine("also in long: " + resultInLong);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
