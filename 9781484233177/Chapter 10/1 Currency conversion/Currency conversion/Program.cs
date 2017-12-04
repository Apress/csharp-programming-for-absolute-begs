using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            Console.Write("Enter amount in euros: ");
            string inputEuros = Console.ReadLine();
            double amountEuros = Convert.ToDouble(inputEuros);

            Console.Write("Enter euro exchange rate (how many dollars per 1 euro): ");
            string inputExchangeRate = Console.ReadLine();
            double euroEchangeRate = Convert.ToDouble(inputExchangeRate);

            // Calculation
            double amountDollars = amountEuros * euroEchangeRate;

            // Output
            Console.WriteLine("Amount in dollars: " + amountDollars);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
