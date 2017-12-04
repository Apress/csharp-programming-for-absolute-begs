using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summary_evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. PREPARATIONS
            string errorMessage = "Incorrect input";
            int mathematics, computerScience, motherTongue, english;
            bool hasUnexcusedAbsences;

            // 2. INPUTS
            try
            {
                Console.WriteLine("Enter grades from individual subjects:");

                Console.Write("Mathematics: ");
                string input = Console.ReadLine();
                mathematics = Convert.ToInt32(input);
                if (mathematics < 1 || mathematics > 5)
                {
                    Console.WriteLine(errorMessage);
                    return;
                }

                Console.Write("Computer science: ");
                input = Console.ReadLine();
                computerScience = Convert.ToInt32(input);
                if (computerScience < 1 || computerScience > 5)
                {
                    Console.WriteLine(errorMessage);
                    return;
                }

                Console.Write("Mother tongue: ");
                input = Console.ReadLine();
                motherTongue = Convert.ToInt32(input);
                if (motherTongue < 1 || motherTongue > 5)
                {
                    Console.WriteLine(errorMessage);
                    return;
                }

                Console.Write("English: ");
                input = Console.ReadLine();
                english = Convert.ToInt32(input);
                if (english < 1 || english > 5)
                {
                    Console.WriteLine(errorMessage);
                    return;
                }

                Console.Write("Had the pupil unexcused absences? (yes/no): ");
                input = Console.ReadLine();
                input = input.ToLower(); // not distinguishing upper/lower
                if (input != "yes" && input != "no")
                {
                    Console.WriteLine(errorMessage);
                    return;
                }
                hasUnexcusedAbsences = input == "yes";
            }
            catch (Exception)
            {
                Console.WriteLine(errorMessage);
                return;
            }


            // 3. EVALUATION
            // We need arithmetic average of all the grades
            double average = (mathematics + computerScience + motherTongue + english) / 4.0;
            string message;

            // Testing all conditions for excellence
            if (average < 1.5001 &&
                mathematics <= 2 && computerScience <= 2 &&
                motherTongue <= 2 && english <= 2 &&
                !hasUnexcusedAbsences)
            {
                message = "Excellent";
            }
            else
            {
                // Here we know the result is not excellent, so testing the other two possibilities
                if (mathematics == 5 || computerScience == 5 ||
                    motherTongue == 5 || english == 5)
                {
                    message = "Failed";
                }
                else
                {
                    message = "Good";
                }
            }

            // 4. OUTPUT
            Console.WriteLine("Summary evaluation: " + message);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
