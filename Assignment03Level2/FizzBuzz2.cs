using System;

namespace Assignment03Level2
{
    class FizzBuzz2
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
                // Initialize a counter variable for the while loop
                int i = 1;

                // Loop while i is less than or equal to the input number
                while (i <= number)
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

                    // Increment i to move to the next number
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Please enter a positive integer.");
            }
        }
    }
}

