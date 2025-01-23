using System;

namespace Assignment03Level3
{
    class HarshadNumber
    {
        static void Main(string[] args)
        {
            // Declare variables
            int number, sum = 0, originalNumber;

            // Get the user input
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            // Store the original number to use later in the division check
            originalNumber = number;

            // Calculate the sum of the digits using a while loop
            while (number != 0)
            {
                // Find the last digit and add it to the sum
                sum += number % 10;

                // Remove the last digit
                number /= 10;
            }

            // Check if the original number is divisible by the sum of its digits
            if (originalNumber % sum == 0)
            {
                // If divisible, it's a Harshad number
                Console.WriteLine(originalNumber + " is a Harshad number.");
            }
            else
            {
                // Otherwise, it's not a Harshad number
                Console.WriteLine(originalNumber + " is not a Harshad number.");
            }
        }
    }
}