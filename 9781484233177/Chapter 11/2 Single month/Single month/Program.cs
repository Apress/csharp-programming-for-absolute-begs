using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_month
{
    class Program
    {
        static void Main(string[] args)
        {
            // Date input
            Console.Write("Enter a date: ");
            string input = Console.ReadLine();
            DateTime enteredDate = Convert.ToDateTime(input);

            // Calculations
            int enteredYear = enteredDate.Year;
            int enteredMonth = enteredDate.Month;

            DateTime firstDayOfMonth = new DateTime(enteredYear, enteredMonth, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            // Outputs
            Console.WriteLine();
            Console.WriteLine("Corresponding month: " +
                "from " + firstDayOfMonth.ToShortDateString() +
                " to " + lastDayOfMonth.ToShortDateString());

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
