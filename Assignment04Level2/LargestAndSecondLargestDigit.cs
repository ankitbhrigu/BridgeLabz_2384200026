using System;

namespace Assignment04Level2
{
    class LargestAndSecondLargestDigit
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

            // Define maxDigit variable for the array size, initially set to 10
            int maxDigit = 10;

            // Array to store the digits of the number
            int[] digits = new int[maxDigit];

            // Index variable to reflect the array index
            int index = 0;

            // Loop to extract digits from the number and store them in the array
            while (number != 0)
            {
                // Get the last digit of the number and add it to the array
                digits[index] = number % 10;

                // Remove the last digit from the number
                number /= 10;

                // Increment the index
                index++;

                // If index reaches maxDigit, break the loop
                if (index == maxDigit)
                {
                    break;
                }
            }

            // Variables to store the largest and second-largest digits
            int largest = -1;
            int secondLargest = -1;

            // Loop to find the largest and second-largest digits
            for (int i = 0; i < index; i++)
            {
                if (digits[i] > largest)
                {
                    secondLargest = largest;
                    largest = digits[i];
                }
                else if (digits[i] > secondLargest && digits[i] != largest)
                {
                    secondLargest = digits[i];
                }
            }

            // Display the largest and second-largest digits
            Console.WriteLine($"\nLargest digit: {largest}");
            Console.WriteLine($"Second largest digit: {secondLargest}");
        }
    }
}

