using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path_to_desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Finding path to the desktop
            string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Output
            Console.WriteLine("Path to your desktop: " + pathToDesktop);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
