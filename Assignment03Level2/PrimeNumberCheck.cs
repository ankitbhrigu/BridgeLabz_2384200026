using System;

namespace Assignment03Level2
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            // Declare a variable to store the input number
            int number;
            
            // Declare a boolean variable to store the result
            bool isPrime = true;

            // Prompt the user to input the number
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is greater than 1 (Prime numbers must be greater than 1)
            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                // Loop through numbers from 2 to the input number-1
                for (int i = 2; i < number; i++)
                {
                    // Check if the number is divisible by i
                    if (number % i == 0)
                    {
                        // If divisible, it is not a prime number, set isPrime to false and break out of the loop
                        isPrime = false;
                        break;
                    }
                }
            }

            // Output the result based on the value of isPrime
            if (isPrime)
            {
                Console.WriteLine($"{number} is a Prime Number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a Prime Number.");
            }
        }
    }
}

