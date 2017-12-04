using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            Console.Write("Enter customer price of a product: ");
            string inputPrice = Console.ReadLine();
            double customerPrice = Convert.ToDouble(inputPrice);

            Console.Write("Enter VAT rate in %: ");
            string inputVatRate = Console.ReadLine();
            double vatRate = Convert.ToDouble(inputVatRate);

            // Calculations
            double divisor = 1 + vatRate / 100.0;
            double calculatedPriceWithoutVat = customerPrice / divisor;
            double priceWithoutVat = Math.Round(calculatedPriceWithoutVat, 2);
            double vat = customerPrice - priceWithoutVat;

            // Outputs
            Console.WriteLine();
            Console.WriteLine("Price without VAT: " + priceWithoutVat.ToString("N2"));
            Console.WriteLine("VAT: " + vat.ToString("N2"));

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
