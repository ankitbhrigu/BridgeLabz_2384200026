using System;

namespace Assignment03Level2
{
    class MultiplesBelow100
    {
        static void Main(string[] args)
        {
            // Declare a variable to store the input number
            int number;

            // Prompt the user to input a number
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            // Loop backward from 100 to 1 to find multiples of the number below 100
            Console.WriteLine($"The multiples of {number} below 100 are:");

            for (int i = 100; i >= 1; i--)
            {
                // Check if i is divisible by the number (i.e., a multiple of the number)
                if (i % number == 0)
                {
                    // Print the multiple
                    Console.WriteLine(i);
                }
            }
        }
    }
}

