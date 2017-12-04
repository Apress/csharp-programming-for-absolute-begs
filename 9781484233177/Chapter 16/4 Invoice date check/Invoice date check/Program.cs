using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_date_check
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            Console.Write("Payment date: ");
            string inputPayment = Console.ReadLine();
            DateTime paymentDate = Convert.ToDateTime(inputPayment);

            Console.Write("Invoice date: ");
            string inputInvoice = Console.ReadLine();
            DateTime invoiceDate = Convert.ToDateTime(inputInvoice);

            // Checking
            bool ok = true;
            if (invoiceDate < paymentDate)
            {
                Console.WriteLine("Invoice date cannot precede payment date.");
                ok = false;
            }
            if (invoiceDate > paymentDate.AddDays(15))
            {
                Console.WriteLine("Invoice cannot be issued later than 15 days after payment.");
                ok = false;
            }
            if (ok)
            {
                Console.WriteLine("Dates accepted.");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
