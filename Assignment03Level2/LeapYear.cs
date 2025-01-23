using System;
namespace Assignment03Level2
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            // Declare a variable to store the input year
            int year;

            // Prompt the user to input the year
            Console.Write("Enter a year: ");
            year = Convert.ToInt32(Console.ReadLine());

            // Check Gregorian calendar year
            if (year >= 1582)
            {
                // Multiple if-else statements for determining leap year
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                {
                    Console.WriteLine($"{year} is a Leap Year.");
                }
                else
                {
                    Console.WriteLine($"{year} is not a Leap Year.");
                }
            }
            else
            {
                // Output if the year is before 1582
                Console.WriteLine("Year must be 1582 or later.");
            }

            // Second part: One if statement using logical operators
            if (year >= 1582 && ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0))
            {
                Console.WriteLine($"{year} is a Leap Year (using logical operators).");
            }
            else if (year >= 1582)
            {
                Console.WriteLine($"{year} is not a Leap Year (using logical operators).");
            }
        }
    }
}

