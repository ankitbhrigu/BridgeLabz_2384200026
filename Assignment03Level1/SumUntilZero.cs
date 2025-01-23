using System;

namespace Assignment_03A
{
    class SumUntilZero
    {
        static void Main(string[] args)
        {
            // Declare and initialize the total variable
            double total = 0.0;

            // Variable to store the user's input
            double userInput;

            // Loop to calculate the sum until the user enters 0
            do
            {
                Console.Write("Enter a number (0 to stop): ");
                userInput = Convert.ToDouble(Console.ReadLine());
                
                // Add the input to the total if it's not zero
                if (userInput != 0)
                {
                    total += userInput;
                }

            } while (userInput != 0);

            // Display the total sum
            Console.WriteLine($"The total sum is: {total}");
        }
    }
}