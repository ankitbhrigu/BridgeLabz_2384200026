using System;

namespace Assignment04Level1
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            // Variable to store the user-entered number
            int number;

            // Get user input and validate for positive integer
            while (true)
            {
                Console.Write("Enter a positive number: ");
                if (int.TryParse(Console.ReadLine(), out number) && number > 0)
                {
                    break; // Exit the loop if valid input is provided
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid positive integer.");
                }
            }

            // Create a string array to store the results
            string[] results = new string[number + 1];

            // Loop through numbers from 0 to the user-entered number and determine Fizz, Buzz, or FizzBuzz
            for (int i = 0; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    results[i] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    results[i] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    results[i] = "Buzz";
                }
                else
                {
                    results[i] = i.ToString();
                }
            }

            // Loop to print the results in the specified format
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine($"Position {i} = {results[i]}");
            }
        }
    }
}



