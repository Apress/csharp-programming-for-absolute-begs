using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternating_loop_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Preparations
            Console.WriteLine("My main to-do list:");
            int taskNumber = 1;

            for (int coupleCount = 0; coupleCount < 5; coupleCount++)
            {
                // Couple output and adjusting task number
                Console.WriteLine(taskNumber.ToString() + ". Learning");
                taskNumber++;
                Console.WriteLine(taskNumber.ToString() + ". Dating");
                taskNumber++;
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
