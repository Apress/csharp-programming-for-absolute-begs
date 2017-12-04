using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternating_loop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Preparations
            Console.WriteLine("My main to-do list:");
            bool learning = true;

            for (int taskNumber = 1; taskNumber <= 10; taskNumber++)
            {
                // Output
                string taskText = learning ? "Learning" : "Dating";
                Console.WriteLine(taskNumber.ToString() + ". " + taskText);

                // Toggling of the flag
                learning = !learning;
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
