using System;

namespace Assignment_03A
{
    class FactorialWhileLoop
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter an integer
            Console.Write("Enter a positive integer to find its factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is a positive integer
            if (number >= 0)
            {
                // Compute the factorial using a while loop
                int factorial = 1;
                int counter = number;

                while (counter > 0)
                {
                    factorial *= counter;
                    counter--;
                }

                // Display the result
                Console.WriteLine($"The factorial of {number} is {factorial}.");
            }
            else
            {
                // Display a message if the input is not a positive integer
                Console.WriteLine($"The number {number} is not a positive integer.");
            }
        }
    }
}