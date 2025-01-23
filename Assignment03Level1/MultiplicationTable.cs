using System;

namespace Assignment_03A
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number to generate its multiplication table: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Loop through the range from 6 to 9
            for (int i = 6; i <= 9; i++)
            {
                // Print the multiplication result
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}

