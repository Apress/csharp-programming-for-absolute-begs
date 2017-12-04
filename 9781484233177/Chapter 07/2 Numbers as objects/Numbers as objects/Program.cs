using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_as_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Some number
            int number = 1234;

            // Conversion to text
            //string numberAsText = number; // DOES NOT WORK!
            string numberAsText = number.ToString();

            // Output
            Console.WriteLine("Output of number: " + number);
            Console.WriteLine("Output of text: " + numberAsText);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
