using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_consumption
{
    class Program
    {
        static void Main(string[] args)
        {
            // Outputs
            Console.WriteLine("Whole numbers");
            Console.WriteLine("-------------");
            Console.WriteLine("byte:   " + sizeof(byte));
            Console.WriteLine("sbyte:  " + sizeof(sbyte));
            Console.WriteLine();
            Console.WriteLine("short:  " + sizeof(short));
            Console.WriteLine("ushort: " + sizeof(ushort));
            Console.WriteLine();
            Console.WriteLine("int:    " + sizeof(int));
            Console.WriteLine("uint:   " + sizeof(uint));
            Console.WriteLine();
            Console.WriteLine("long:   " + sizeof(long));
            Console.WriteLine("ulong:  " + sizeof(ulong));
            Console.WriteLine();
            Console.WriteLine("Decimal numbers");
            Console.WriteLine("---------------");
            Console.WriteLine("float:    " + sizeof(float));
            Console.WriteLine("double:   " + sizeof(double));
            Console.WriteLine("decimal:  " + sizeof(decimal));
            Console.WriteLine();

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
