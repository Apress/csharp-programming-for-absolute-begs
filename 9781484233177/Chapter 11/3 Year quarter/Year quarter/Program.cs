using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year_quarter
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

            int numberOfQuarter = (enteredMonth + 2) / 3;
            int monthOfQuarterStart = 3 * numberOfQuarter - 2;
            DateTime firstDayOfQuarter = new DateTime(enteredYear, monthOfQuarterStart, 1);
            DateTime lastDayOfQuarter = firstDayOfQuarter.AddMonths(3).AddDays(-1);

            // Outputs
            Console.WriteLine();
            Console.WriteLine("Corresponding quarter: " +
                "number-" + numberOfQuarter +
                ", from " + firstDayOfQuarter.ToShortDateString() +
                " to " + lastDayOfQuarter.ToShortDateString());

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
