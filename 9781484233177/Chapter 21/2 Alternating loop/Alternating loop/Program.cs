using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternating_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output
            Console.WriteLine("My main to-do list:");

            for (int taskNumber = 1; taskNumber <= 10; taskNumber++)
            {
                string taskText = taskNumber % 2 != 0 ? "Learning" : "Dating";
                Console.WriteLine(taskNumber.ToString() + ". " + taskText);
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
