using System;

namespace Assignment_03A
{
    class OddEvenNumbers
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a natural number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is a natural number
            if (number >= 1)
            {
                // Loop through numbers from 1 to the entered number
                for (int i = 1; i <= number; i++)
                {
                    // Check if the number is even or odd
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"{i} is an even number.");
                    }
                    else
                    {
                        Console.WriteLine($"{i} is an odd number.");
                    }
                }
            }
            else
            {
                // Display a message if the input is not a natural number
                Console.WriteLine("Please enter a natural number greater than or equal to 1.");
            }
        }
    }
}