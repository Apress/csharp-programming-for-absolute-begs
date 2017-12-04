using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Some money amounts and a number
            double amount = 1234.56;
            double anotherAmount = 789;
            int wholeNumber = 1234567;

            // Formatted outputs
            Console.WriteLine("Separating thousands and millions + money to cents");
            Console.WriteLine(amount.ToString("N2"));
            Console.WriteLine(anotherAmount.ToString("N2"));
            Console.WriteLine(wholeNumber.ToString("N0"));

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
