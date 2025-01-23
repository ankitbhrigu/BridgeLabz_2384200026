using System;

namespace Assignment03Level3
{
    class AbundantNumber
    {
        static void Main(string[] args)
        {
            // Declare variables
            int number, sum = 0;

            // Get the user input
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            // Find the sum of divisors of the number
            for (int i = 1; i < number; i++)
            {
                // Check if i is a divisor of the number
                if (number % i == 0)
                {
                    // Add the divisor to the sum
                    sum += i;
                }
            }

            // Check if the sum of divisors is greater than the number
            if (sum > number)
            {
                // If yes, it's an Abundant Number
                Console.WriteLine(number + " is an Abundant number.");
            }
            else
            {
                // If no, it's not an Abundant Number
                Console.WriteLine(number + " is not an Abundant number.");
            }
        }
    }
}