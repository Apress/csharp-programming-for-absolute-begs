using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_components
{
    class Program
    {
        static void Main(string[] args)
        {
            // Current date and time (using single statement)
            DateTime now = DateTime.Now;

            // Picking up individual components
            int day = now.Day;
            int month = now.Month;
            int year = now.Year;
            int hours = now.Hour;
            int minutes = now.Minute;
            int seconds = now.Second;
            DateTime justDateWithoutTime = now.Date;

            // Output
            Console.WriteLine("Day: " + day);
            Console.WriteLine("Month: " + month);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Hours: " + hours);
            Console.WriteLine("Minutes: " + minutes);
            Console.WriteLine("Seconds: " + seconds);
            Console.WriteLine("Date component: " + justDateWithoutTime);

            // Formatting output our way
            Console.WriteLine("Our output: " +
                year + ", " + month + "/" + day + 
                " " +
                hours + " hours " + minutes + " minutes");

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
