using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_assignment_and_texts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial value (empty text)
            string books = "";

            // Appending
            books += "Homage to Catalonia" + Environment.NewLine;
            books += "Silent Spring" + Environment.NewLine;
            books += "The beat of a different drum" + Environment.NewLine;

            // Output
            Console.WriteLine("Valuable books");
            Console.WriteLine("--------------");
            Console.WriteLine(books);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
