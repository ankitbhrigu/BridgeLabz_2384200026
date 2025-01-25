using System;
namespace Assignment04Level1
{
    class StoreAndSumNumbers
    {
        static void Main(string[] args)
        {
            // Array to store up to 10 numbers
            double[] numbers = new double[10];

            // Variable to store the total of the numbers
            double total = 0.0;

            // Index variable for the array
            int index = 0;

            Console.WriteLine("Enter numbers (up to 10). Enter 0 or a negative number to stop:");

            // Infinite loop to take user input
            while (true)
            {
                Console.Write($"Enter number {index + 1}: ");
                string userInput = Console.ReadLine();

                // Validate if the input is a valid double
                if (double.TryParse(userInput, out double inputNumber))
                {
                    // Check if the user entered 0 or a negative number
                    if (inputNumber <= 0)
                    {
                        Console.WriteLine("Input is 0 or a negative number. Stopping input.");
                        break;
                    }

                    // Assign the number to the array element
                    numbers[index] = inputNumber;

                    // Increment the index
                    index++;

                    // Break if the maximum number of inputs (10) is reached
                    if (index == numbers.Length)
                    {
                        Console.WriteLine("Maximum number of inputs reached.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid number.");
                }
            }

            // Calculate the sum of the entered numbers
            for (int i = 0; i < index; i++)
            {
                total += numbers[i];
            }

            // Display the entered numbers
            Console.WriteLine("\nEntered Numbers:");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Display the total
            Console.WriteLine($"\nTotal Sum of Numbers: {total}");
        }
    }
}

