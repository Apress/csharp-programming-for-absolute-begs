using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appending_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter image name: ");
            string fileName = Console.ReadLine();

            // Appending extension (ONLY IN CASE OF NEED)
            if (!fileName.ToLower().EndsWith(".png"))
            {
                fileName += ".png";
            }

            // Output
            Console.WriteLine("We are going to use name: " + fileName);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
