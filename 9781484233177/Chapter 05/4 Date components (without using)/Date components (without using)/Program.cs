//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Date_components__without_using_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Current date and time (using single statement)
            System.DateTime now = System.DateTime.Now;

            // Picking up individual components
            int day = now.Day;
            int month = now.Month;
            int year = now.Year;
            int hours = now.Hour;
            int minutes = now.Minute;
            int seconds = now.Second;
            System.DateTime justDateWithoutTime = now.Date;

            // Output
            System.Console.WriteLine("Day: " + day);
            System.Console.WriteLine("Month: " + month);
            System.Console.WriteLine("Year: " + year);
            System.Console.WriteLine("Hours: " + hours);
            System.Console.WriteLine("Minutes: " + minutes);
            System.Console.WriteLine("Seconds: " + seconds);
            System.Console.WriteLine("Date component: " + justDateWithoutTime);

            // Formatting output our way
            System.Console.WriteLine("Our output: " +
                year + ", " + month + "/" + day +
                " " +
                hours + " hours " + minutes + " minutes");

            // Waiting for Enter
            System.Console.ReadLine();
        }
    }
}
