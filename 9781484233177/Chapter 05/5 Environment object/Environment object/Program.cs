using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Environment_object
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displaying components of Environment object
            Console.WriteLine("Device name: " + Environment.MachineName);
            Console.WriteLine("64-bit system: " + Environment.Is64BitOperatingSystem);
            Console.WriteLine("User name: " + Environment.UserName);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
