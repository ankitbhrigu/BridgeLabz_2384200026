using System;

namespace Assignment03Level2
{
    class FactorsOfNumber
    {
        static void Main(string[] args)
        {
            // Declare a variable to store the input number
            int number;

            // Prompt the user to input a number
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            // Check for factors of the number
            Console.WriteLine($"The factors of {number} are:");

            // Loop from 1 to number-1 to find factors
            for (int i = 1; i < number; i++)
            {
                // Check if number is divisible by i
                if (number % i == 0)
                {
                    // If true, print i as a factor
                    Console.WriteLine(i);
                }
            }
        }
    }
}

