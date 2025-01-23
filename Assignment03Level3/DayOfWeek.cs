using System;

namespace Assignment03Level3
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            // Declare variables for month, day, and year
            int month, day, year;

            // Ensure that the correct number of arguments is passed
            if (args.Length != 3)
            {
                Console.WriteLine("Please provide three arguments: month, day, and year.");
                return;
            }

            // Parse the input arguments into integers
            month = int.Parse(args[0]);
            day = int.Parse(args[1]);
            year = int.Parse(args[2]);

            // Apply the given formulas

            // Calculate y0 using the formula
            int y0 = year - (14 - month) / 12;

            // Calculate x using the formula
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;

            // Calculate m0 using the formula
            int m0 = month + 12 * ((14 - month) / 12) - 2;

            // Calculate d0 using the formula
            int d0 = (day + x + (31 * m0) / 12) % 7;

            // Output the result
            Console.WriteLine($"The day of the week is: {d0}");
        }
    }
}

