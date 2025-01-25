using System;

namespace Assignment04Level1
{
    class MultiplicationTableFromSixToNine
    {
        static void Main(string[] args)
        {
            // Variable to store the user-entered number
            int number;

            // Array to store multiplication results for numbers from 6 to 9
            int[] multiplicationResults = new int[4];

            // Get user input for the number
            while (true)
            {
                Console.Write("Enter a number to generate its multiplication table (from 6 to 9): ");
                string userInput = Console.ReadLine();

                // Validate if the input is a valid integer
                if (int.TryParse(userInput, out number))
                {
                    break; // Exit the loop if input is valid
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
                }
            }

            // Generate the multiplication table from 6 to 9
            for (int i = 0; i < multiplicationResults.Length; i++)
            {
                multiplicationResults[i] = number * (6 + i); // 6 + i gives values from 6 to 9
            }

            // Display the multiplication table
            Console.WriteLine($"\nMultiplication Table of {number} from 6 to 9:");
            for (int i = 0; i < multiplicationResults.Length; i++)
            {
                int multiplier = 6 + i; // Get the multiplier (6 to 9)
                Console.WriteLine($"{number} * {multiplier} = {multiplicationResults[i]}");
            }
        }
    }
}