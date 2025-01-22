using System;
namespace Assignment_03
{
    class SwapNumbers
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            // Swapping the numbers using a temporary variable
            int temp = number1;
            number1 = number2;
            number2 = temp;

            // Output
            Console.WriteLine($"The swapped numbers are {number1} and {number2}.");
        }
    }
}