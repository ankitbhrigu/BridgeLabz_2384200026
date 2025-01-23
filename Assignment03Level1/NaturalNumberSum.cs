using System;
namespace Assignment_03A
{
    class NaturalNumberSum
    {
        static void Main(string[] args)
        {
            // Declare a variable to store the user input
            Console.Write("Enter a number to check if it is a natural number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is a natural number
            if (number >= 0)
            {
                // Calculate the sum of n natural numbers
                int sumOfNaturalNumbers = number * (number + 1) / 2;

                // Display the result
                Console.WriteLine($"The sum of {number} natural numbers is {sumOfNaturalNumbers}.");
            }
            else
            {
                // Display the result if the number is not natural
                Console.WriteLine($"The number {number} is not a natural number.");
            }
        }
    }
}