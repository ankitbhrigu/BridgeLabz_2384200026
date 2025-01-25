using System;
namespace Assignment04Level1
{
    class NumberAnalysis
    {
        static void Main(string[] args)
        {
            // Define the number of elements in the array
            int arraySize = 5;

            // Array to store numbers
            int[] numbers = new int[arraySize];

            // Prompt user for input and validate
            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    string userInput = Console.ReadLine();

                    // Validate if the input is a valid integer
                    if (int.TryParse(userInput, out int number))
                    {
                        numbers[i] = number;
                        break; // Exit the loop if input is valid
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
                    }
                }
            }

            // Analyze each number in the array
            Console.WriteLine("\nNumber Analysis:");
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber > 0)
                {
                    // Check if the number is even or odd
                    string evenOdd = (currentNumber % 2 == 0) ? "even" : "odd";
                    Console.WriteLine($"Number {currentNumber} is positive and {evenOdd}.");
                }
                else if (currentNumber < 0)
                {
                    Console.WriteLine($"Number {currentNumber} is negative.");
                }
                else
                {
                    Console.WriteLine("Number 0 is zero.");
                }
            }

            // Compare the first and last elements
            Console.WriteLine("\nComparison of the first and last elements:");
            int firstElement = numbers[0];
            int lastElement = numbers[numbers.Length - 1];

            if (firstElement == lastElement)
            {
                Console.WriteLine($"The first element ({firstElement}) and the last element ({lastElement}) are equal.");
            }
            else if (firstElement > lastElement)
            {
                Console.WriteLine($"The first element ({firstElement}) is greater than the last element ({lastElement}).");
            }
            else
            {
                Console.WriteLine($"The first element ({firstElement}) is less than the last element ({lastElement}).");
            }
        }
    }

}

