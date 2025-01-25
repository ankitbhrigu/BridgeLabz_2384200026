using System;

namespace Assignment04Level1
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            // Variable to store the number for which the multiplication table is generated
            int number;

            // Array to store the results of the multiplication table
            int[] multiplicationResults = new int[10];

            // Get user input for the number
            while (true)
            {
                Console.Write("Enter a number to generate its multiplication table: ");
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

            // Generate the multiplication table and store results in the array
            for (int i = 0; i < multiplicationResults.Length; i++)
            {
                multiplicationResults[i] = number * (i + 1);
            }

            // Display the multiplication table
            Console.WriteLine($"\nMultiplication Table of {number}:");
            for (int i = 0; i < multiplicationResults.Length; i++)
            {
                Console.WriteLine($"{number} * {i + 1} = {multiplicationResults[i]}");
            }
        }
    }
}

