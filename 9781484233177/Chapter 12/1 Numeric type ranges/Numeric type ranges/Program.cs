using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeric_type_ranges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Immediately outputs
            Console.WriteLine("Signed whole numbers");
            Console.WriteLine("--------------------");
            Console.WriteLine("sbyte:  " + sbyte.MinValue + " to " + sbyte.MaxValue);
            Console.WriteLine("short:  " + short.MinValue + " to " + short.MaxValue);
            Console.WriteLine("int:    " + int.MinValue + " to " + int.MaxValue);
            Console.WriteLine("long:   " + long.MinValue + " to " + long.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Unsigned whole numbers");
            Console.WriteLine("----------------------");
            Console.WriteLine("byte:   " + byte.MinValue + " to " + byte.MaxValue);
            Console.WriteLine("ushort: " + ushort.MinValue + " to " + ushort.MaxValue);
            Console.WriteLine("unit:   " + uint.MinValue + " to " + uint.MaxValue);
            Console.WriteLine("ulong:  " + ulong.MinValue + " to " + ulong.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Basic decimal numbers");
            Console.WriteLine("---------------------");
            Console.WriteLine("float:  " + float.MinValue + " to " + float.MaxValue);
            Console.WriteLine("double: " + double.MinValue + " to " + double.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Exact decimal numbers");
            Console.WriteLine("---------------------");
            Console.WriteLine("decimal:  " + decimal.MinValue + " to " + decimal.MaxValue);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
