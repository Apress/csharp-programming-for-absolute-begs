using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Every_week_until_end_of_year
{
    class Program
    {
        static void Main(string[] args)
        {
            // Today
            DateTime today = DateTime.Today;
            int thisYear = today.Year;

            // Repeating
            DateTime date = today;
            do
            {
                // Output
                Console.WriteLine(date.ToLongDateString());

                // Preparing next output (a week later)
                date = date.AddDays(7);
            } while (date.Year == thisYear);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
