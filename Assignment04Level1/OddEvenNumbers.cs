using System;

namespace Assignment04Level1
{
    class OddEvenNumbers
    {
        static void Main(string[] args)
        {
            // Variable to store the user-entered number
            int number;

            // Get user input and validate for natural number
            while (true)
            {
                Console.Write("Enter a natural number: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out number) && number > 0)
                {
                    break; // Exit the loop if valid input is provided
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid natural number (greater than 0).");
                }
            }

            // Determine the maximum size for odd and even arrays
            int maxArraySize = number / 2 + 1;

            // Arrays to store odd and even numbers
            int[] oddNumbers = new int[maxArraySize];
            int[] evenNumbers = new int[maxArraySize];

            // Index variables for odd and even arrays
            int oddIndex = 0;
            int evenIndex = 0;

            // Loop through numbers from 1 to the user-entered number
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers[evenIndex++] = i; // Save even number and increment the even index
                }
                else
                {
                    oddNumbers[oddIndex++] = i; // Save odd number and increment the odd index
                }
            }

            // Print odd numbers
            Console.WriteLine("\nOdd Numbers:");
            for (int i = 0; i < oddIndex; i++)
            {
                Console.Write(oddNumbers[i] + " ");
            }

            // Print even numbers
            Console.WriteLine("\n\nEven Numbers:");
            for (int i = 0; i < evenIndex; i++)
            {
                Console.Write(evenNumbers[i] + " ");
            }

            Console.WriteLine();
        }
    }
}




