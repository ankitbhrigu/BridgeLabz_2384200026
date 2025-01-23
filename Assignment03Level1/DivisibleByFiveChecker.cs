using System;

namespace Assignment_03A
{
    class DivisibleByFiveChecker
    {
        static void Main(string[] args)
        {
            // Declare a variable to store the user input
            Console.Write("Enter a number to check divisibility by 5: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            // Check if the number is divisible by 5
            int remainder = inputNumber % 5;

            // Display the result
            if (remainder == 0)
            {
                Console.WriteLine($"Is the number {inputNumber} divisible by 5? Yes");
            }
            else
            {
                Console.WriteLine($"Is the number {inputNumber} divisible by 5? No");
            }
        }
    }
}