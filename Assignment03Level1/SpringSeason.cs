using System;

namespace Assignment_03A
{
    class SpringSeason
    {
        static void Main(string[] args)
        {
            // Check if the correct number of arguments is provided
            if (args.Length < 2)
            {
                Console.WriteLine("Please provide both month and day as command-line arguments.");
                return;
            }

            // Parse the command-line arguments
            int month = Convert.ToInt32(args[0]);
            int day = Convert.ToInt32(args[1]);

            // Check if the date is in the spring season (March 20 - June 20)
            if ((month == 3 && day >= 20) || (month > 3 && month < 6) || (month == 6 && day <= 20))
            {
                Console.WriteLine("It's a Spring Season.");
            }
            else
            {
                Console.WriteLine("Not a Spring Season.");
            }
        }
    }
}

