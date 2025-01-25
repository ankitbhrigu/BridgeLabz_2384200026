
using System;

namespace Assignment04Level2
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            // Variable to store the user input number
            int number;

            // Get user input and validate it
            while (true)
            {
                Console.Write("Enter a positive integer: ");
                if (int.TryParse(Console.ReadLine(), out number) && number > 0)
                {
                    break; // Exit loop if valid input is entered
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid positive integer.");
                }
            }

            // Find the count of digits in the number
            int temp = number;
            int digitCount = 0;
            while (temp != 0)
            {
                temp /= 10;
                digitCount++;
            }

            // Create an array to store the digits
            int[] digits = new int[digitCount];

            // Store the digits of the number in the digits array
            temp = number;
            for (int i = 0; i < digitCount; i++)
            {
                digits[i] = temp % 10;
                temp /= 10;
            }

            // Create an array to store the digits in reverse order
            int[] reversedDigits = new int[digitCount];

            // Fill the reversedDigits array with the elements from the digits array
            for (int i = 0; i < digitCount; i++)
            {
                reversedDigits[i] = digits[digitCount - i - 1];
            }

            // Display the reversed number by iterating over the reversedDigits array
            Console.Write("Reversed number: ");
            for (int i = 0; i < digitCount; i++)
            {
                Console.Write(reversedDigits[i]);
            }
            Console.WriteLine();
        }
    }
}

