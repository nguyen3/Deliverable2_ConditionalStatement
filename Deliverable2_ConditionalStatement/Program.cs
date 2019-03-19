/*
 Author: Trang Nguyen
 Date: 1/17/2019
 Comment: This C# Console application code demonstrates the use of 
          conditional statements for different grade of MIS Capstones class.
*/

using System;

namespace Deliverable2_ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to input their expected grade for MIS4300
            Console.WriteLine("Type the grade that you expect to get in ISM4300:");

            //Use try-catch block to validate the user input
            try
            {
                //Gather the user input
                string input = Console.ReadLine();

                //Get the grade
                int grade = int.Parse(input);

                //Use IF Statement to get the letter grade
                if (grade > 97)
                {
                    Console.WriteLine("Your expected letter grade is A+");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(true);
                }
                else if ((grade > 91) && (grade < 98))
                {
                    Console.WriteLine("Your expected letter grade is A");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(true);
                }
                else if ((grade > 89) && (grade < 92))
                {
                    Console.WriteLine("Your expected letter grade is A-");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(true);
                }
                else if ((grade > 87) && (grade < 90))
                {
                    Console.WriteLine("Your expected letter grade is B+");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(true);
                }
                else if ((grade > 81) && (grade < 88))
                {
                    Console.WriteLine("Your expected letter grade is B");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(true);
                }
                else if ((grade > 79) && (grade < 82))
                {
                    Console.WriteLine("Your expected letter grade is B-");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(true);
                }
                else if ((grade > 77) && (grade < 80))
                {
                    Console.WriteLine("Your expected letter grade is C+");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(true);
                }
                else if ((grade > 71) && (grade < 78))
                {
                    Console.WriteLine("Your expected letter grade is C");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(true);
                }
                else if ((grade > 69) && (grade < 72))
                {
                    Console.WriteLine("Your expected letter grade is C-");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(true);
                }
                else if ((grade > 67) && (grade < 70))
                {
                    Console.WriteLine("Your expected letter grade is D+");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(true);
                }
                else if ((grade > 61) && (grade < 68))
                {
                    Console.WriteLine("Your expected letter grade is D");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(true);
                }
                else if ((grade > 59) && (grade < 62))
                {
                    Console.WriteLine("Your expected letter grade is D-");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Your expected letter grade is F");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(true);
                }
            } //End of try

            catch
            {
                Console.WriteLine("Please use an integer data type for your expected grade next time...");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey(true);
            }//End of catch
        }//End of Main
    }//End of class
}//End of namespace
