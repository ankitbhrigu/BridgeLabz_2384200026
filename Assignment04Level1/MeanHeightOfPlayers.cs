
using System;

namespace Assignment04Level1
{
    class MeanHeightOfPlayers
    {
        static void Main(string[] args)
        {
            // Array to store the heights of 11 players
            double[] heights = new double[11];

            // Variable to store the total sum of heights
            double totalHeight = 0.0;

            Console.WriteLine("Enter the heights of 11 players in the football team (in cm):");

            // Get input values for the heights
            for (int i = 0; i < heights.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Enter height of player {i + 1}: ");
                    string userInput = Console.ReadLine();

                    // Validate if the input is a valid double
                    if (double.TryParse(userInput, out double height) && height > 0)
                    {
                        heights[i] = height;
                        break; // Exit the loop if input is valid
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid input. Please enter a valid positive height in cm.");
                    }
                }
            }

            // Calculate the total height of all players
            for (int i = 0; i < heights.Length; i++)
            {
                totalHeight += heights[i];
            }

            // Calculate the mean height
            double meanHeight = totalHeight / heights.Length;

            // Display the mean height
            Console.WriteLine($"\nThe mean height of the football team is: {meanHeight:F2} cm");
        }
    }
}

