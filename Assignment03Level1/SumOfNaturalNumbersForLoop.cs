using System;

namespace Assignment_03A
{
    class SumOfNaturalNumbersForLoop
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a natural number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is a natural number
            if (number >= 0)
            {
                // Compute the sum using the formula
                int sumUsingFormula = number * (number + 1) / 2;

                // Compute the sum using a for loop
                int sumUsingLoop = 0;

                for (int i = 1; i <= number; i++)
                {
                    sumUsingLoop += i;
                }

                // Display the results
                Console.WriteLine($"Sum using formula: {sumUsingFormula}");
                Console.WriteLine($"Sum using for loop: {sumUsingLoop}");

                // Compare the results
                if (sumUsingFormula == sumUsingLoop)
                {
                    Console.WriteLine("The results from both computations match.");
                }
                else
                {
                    Console.WriteLine("The results from both computations do not match.");
                }
            }
            else
            {
                // Display a message if the input is not a natural number
                Console.WriteLine($"The number {number} is not a natural number.");
            }
        }
    }
}