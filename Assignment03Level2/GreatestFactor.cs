
using System;
namespace Assignment03Level2
{
    class GreatestFactor
    {
        static void Main(string[] args)
        {
            // Declare a variable to store the input number
            int number;

            // Declare a variable to store the greatest factor
            int greatestFactor = 1;

            // Prompt the user to input a number
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            // Loop from the number-1 down to 1
            for (int i = number - 1; i >= 1; i--)
            {
                // Check if the number is divisible by i
                if (number % i == 0)
                {
                    // If divisible, assign i to greatestFactor
                    greatestFactor = i;
                    break;
                }
            }

            // Display the greatest factor
            Console.WriteLine($"The greatest factor of {number} (beside itself) is {greatestFactor}.");
        }
    }
}

