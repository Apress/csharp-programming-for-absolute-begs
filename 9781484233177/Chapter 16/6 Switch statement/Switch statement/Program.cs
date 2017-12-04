using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_statement
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
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    spanish = "Lunes";
                    break;
                case DayOfWeek.Tuesday:
                    spanish = "Martes";
                    break;
                case DayOfWeek.Wednesday:
                    spanish = "Miercoles";
                    break;
                case DayOfWeek.Thursday:
                    spanish = "Jueves";
                    break;
                case DayOfWeek.Friday:
                    spanish = "Viernes";
                    break;
                case DayOfWeek.Saturday:
                    spanish = "Sábado";
                    break;
                case DayOfWeek.Sunday:
                    spanish = "Domingo";
                    break;
            }

            // Output
            Console.WriteLine(spanish);
            if (enteredDate == new DateTime(1945, 5, 8))
                Console.WriteLine("The happiest day of the 20th century.");

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
