
using System;

namespace Assignment03Level2
{
    class PowerOfNumber
    {
        static void Main(string[] args)
        {
            // Declare variables for the base number and the power
            int number, power;

            // Declare a variable to store the result, initialized to 1
            int result = 1;

            // Prompt the user to input the number
            Console.Write("Enter the base number: ");
            number = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to input the power
            Console.Write("Enter the power: ");
            power = Convert.ToInt32(Console.ReadLine());

            // Loop to calculate the power of the number
            for (int i = 1; i <= power; i++)
            {
                // Multiply the result by the number in each iteration
                result *= number;
            }

            // Display the result
            Console.WriteLine($"{number} raised to the power of {power} is {result}.");
        }
    }
}

