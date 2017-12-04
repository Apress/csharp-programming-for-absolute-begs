using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanks_God_is_Friday
{
    class Program
    {
        static void Main(string[] args)
        {
            // Today's date
            DateTime today = DateTime.Today;

            // Moving day after day until hit on Friday
            DateTime date = today;
            while (date.DayOfWeek != DayOfWeek.Friday)
            {
                date = date.AddDays(1);
            }

            // Calculating remaining days
            TimeSpan dateDifference = date - today;
            int daysRemaining = dateDifference.Days;

            // Outputs
            Console.WriteLine("Nearest Friday: " + date.ToShortDateString());
            Console.WriteLine("Remaining days: " + daysRemaining.ToString());
            if (daysRemaining == 0)
            {
                Console.WriteLine("Thanks God!");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
