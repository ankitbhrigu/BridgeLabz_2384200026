using System;

namespace Assignment03Level2
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            // Declare a variable to store the input number
            int number;

            // Prompt the user to input a number
            Console.Write("Enter a positive integer: ");
            number = Convert.ToInt32(Console.ReadLine());

            // Check if the input is a positive integer
            if (number > 0)
            {
                // Loop from 0 to the input number
                for (int i = 1; i <= number; i++)
                {
                    // Check if the number is a multiple of both 3 and 5
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    // Check if the number is a multiple of 3
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    // Check if the number is a multiple of 5
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    // Print the number if none of the conditions are met
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a positive integer.");
            }
        }
    }
}