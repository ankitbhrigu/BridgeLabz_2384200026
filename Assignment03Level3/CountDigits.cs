using System;

namespace Assignment03Level3
{
    class CountDigits
    {
        static void Main(string[] args)
        {
            // Declare variables
            int number, count = 0;

            // Get the user input
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            // Use a loop to count the digits
            while (number != 0)
            {
                // Remove the last digit by dividing by 10
                number /= 10;

                // Increase the count by 1 in each iteration
                count++;
            }

            // Display the count of digits
            Console.WriteLine("The number has " + count + " digits.");
        }
    }
}

