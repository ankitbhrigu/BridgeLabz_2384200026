
using System;

namespace Assignment04Level1
{
    class FactorsOfNumber
    {
        static void Main(string[] args)
        {
            // Variable to store the user-entered number
            int number;

            // Get user input and validate
            while (true)
            {
                Console.Write("Enter a number to find its factors: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out number) && number > 0)
                {
                    break; // Exit the loop if the input is a valid positive integer
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid positive integer.");
                }
            }

            // Initialize variables
            int maxFactor = 10; // Initial size of the factors array
            int[] factors = new int[maxFactor]; // Array to store factors
            int index = 0; // To keep track of the current index in the array

            // Find factors of the number
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    // Check if the factors array needs resizing
                    if (index == maxFactor)
                    {
                        // Double the size of the factors array
                        maxFactor *= 2;
                        int[] temp = new int[maxFactor];

                        // Copy existing factors to the temp array
                        for (int j = 0; j < index; j++)
                        {
                            temp[j] = factors[j];
                        }

                        // Assign the temp array back to factors array
                        factors = temp;
                    }

                    // Add the factor to the array
                    factors[index++] = i;
                }
            }

            // Display the factors
            Console.WriteLine($"\nFactors of {number}:");
            for (int i = 0; i < index; i++)
            {
                Console.Write(factors[i] + " ");
            }

            Console.WriteLine();
        }
    }
}

