using System;

namespace Assignment_03A
{
    class SumUntilZeroOrNegative2
    {
        static void Main(string[] args)
        {
            // Declare and initialize the total variable
            double total = 0.0;

            // Infinite loop
            while (true)
            {
                // Prompt the user to enter a number
                Console.Write("Enter a number (negative or 0 to stop): ");
                double userInput = Convert.ToDouble(Console.ReadLine());

                // Break the loop if the input is 0 or negative
                if (userInput <= 0)
                {
                    break;
                }

                // Add the input to the total
                total += userInput;
            }

            // Display the total sum
            Console.WriteLine($"The total sum is: {total}");
        }
    }
}