using System;

namespace Assignment03Level3
{
    class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables
            int number, originalNumber, remainder, sum = 0;

            // Get the user input
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            // Store the original number to compare later
            originalNumber = number;

            // While loop to process each digit of the number
            while (number != 0)
            {
                // Find the remainder (last digit)
                remainder = number % 10;

                // Find the cube of the remainder and add to sum
                sum += (int)Math.Pow(remainder, 3);

                // Update the number by removing the last digit
                number /= 10;
            }

            // Check if the sum is equal to the original number
            if (sum == originalNumber)
            {
                // If yes, it's an Armstrong number
                Console.WriteLine(originalNumber + " is an Armstrong number.");
            }
            else
            {
                // If no, it's not an Armstrong number
                Console.WriteLine(originalNumber + " is not an Armstrong number.");
            }
        }
    }
}

