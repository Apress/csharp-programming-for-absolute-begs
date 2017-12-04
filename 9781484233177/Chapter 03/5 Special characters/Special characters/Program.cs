using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiline output
            Console.WriteLine("First line\r\nSecond line");

            // I prefer specifying "Enter" in more human form
            Console.WriteLine("First line" + Environment.NewLine + "Second line");

            // Text containing a quote
            Console.WriteLine("The letter started so sweet: \"My Darling\"");

            // Unicode characters, in this case Greek beta
            Console.WriteLine("If the font knows, here is Greek beta: \u03B2");

            // Backslashes need to be doubled
            Console.WriteLine("Path to desktop on my computer: " + "C:\\Users\\vystavel\\Desktop");

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
