using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeating_similar_using_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output
            Console.WriteLine("My main to-do list:");

            for (int taskNumber = 1; taskNumber <= 10; taskNumber++)
            {
                Console.WriteLine(taskNumber.ToString() + ". To learn");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
