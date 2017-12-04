using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            Console.Write("Enter customer price of product: ");
            string inputPrice = Console.ReadLine();
            double customerPrice = Convert.ToDouble(inputPrice);

            Console.Write("Enter merchant commission (percents): ");
            string inputMerchantPercents = Console.ReadLine();
            int merchantPercents = Convert.ToInt32(inputMerchantPercents);

            Console.Write("Enter distributor commission (percents): ");
            string inputDistributorPercents = Console.ReadLine();
            int distributorPercents = Convert.ToInt32(inputDistributorPercents);

            // Calculations
            double coeficient1 = 1 - merchantPercents / 100.0;
            double coeficient2 = 1 - distributorPercents / 100.0;

            double wholesalePrice = customerPrice * coeficient1;
            double priceAfterCommissionSubtraction = wholesalePrice * coeficient2;

            double merchantIncome = customerPrice - wholesalePrice;
            double distributorIncome = wholesalePrice - priceAfterCommissionSubtraction;
            double producerIncome = priceAfterCommissionSubtraction;

            // Outputs
            Console.WriteLine();
            Console.WriteLine("Income division");
            Console.WriteLine("----------------");
            Console.WriteLine("Merchant: " + merchantIncome);
            Console.WriteLine("Distributor: " + distributorIncome);
            Console.WriteLine("Producer: " + producerIncome);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
