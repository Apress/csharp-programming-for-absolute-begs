using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spanish_day_of_week
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter a date: ");
            string input = Console.ReadLine();
            DateTime enteredDate = Convert.ToDateTime(input);

            // Finding day of week (in enumeration)
            DayOfWeek dayOfWeek = enteredDate.DayOfWeek;

            // Spanish texts
            string spanish = "";
            if (dayOfWeek == DayOfWeek.Monday)
                spanish = "Lunes";
            if (dayOfWeek == DayOfWeek.Tuesday)
                spanish = "Martes";
            if (dayOfWeek == DayOfWeek.Wednesday)
                spanish = "Miercoles";
            if (dayOfWeek == DayOfWeek.Thursday)
                spanish = "Jueves";
            if (dayOfWeek == DayOfWeek.Friday)
                spanish = "Viernes";
            if (dayOfWeek == DayOfWeek.Saturday)
                spanish = "Sábado";
            if (dayOfWeek == DayOfWeek.Sunday)
                spanish = "Domingo";

            // Output
            Console.WriteLine(spanish);
            if (enteredDate == new DateTime(1945, 5, 8))
                Console.WriteLine("The happiest day of the 20th century.");

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
