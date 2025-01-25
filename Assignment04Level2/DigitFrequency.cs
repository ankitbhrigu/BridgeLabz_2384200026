using System;

namespace Assignment04Level2
{
    class DigitFrequency
    {
        static void Main(string[] args)
        {
            // Take input for the number
            string inputNumber;
            while (true)
            {
                Console.Write("Enter a number: ");
                inputNumber = Console.ReadLine();

                // Ensure the input is a valid number
                if (long.TryParse(inputNumber, out _))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid number.");
                }
            }

            // Create an array to store digits of the number
            int[] digitsArray = new int[inputNumber.Length];

            // Fill the digits array with individual digits from the number
            for (int i = 0; i < inputNumber.Length; i++)
            {
                digitsArray[i] = inputNumber[i] - '0'; // Convert each char digit to an integer
            }

            // Create a frequency array to count the frequency of each digit (0-9)
            int[] frequencyArray = new int[10];

            // Loop through the digits array and increase the frequency of each digit
            for (int i = 0; i < digitsArray.Length; i++)
            {
                int digit = digitsArray[i];
                frequencyArray[digit]++; // Increase the frequency of the digit
            }

            // Display the frequency of each digit in the number
            Console.WriteLine("\nFrequency of each digit:");
            for (int i = 0; i < 10; i++)
            {
                if (frequencyArray[i] > 0)
                {
                    Console.WriteLine($"Digit {i}: {frequencyArray[i]} time(s)");
                }
            }
        }
    }
}

