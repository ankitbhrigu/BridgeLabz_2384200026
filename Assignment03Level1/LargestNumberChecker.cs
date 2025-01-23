using System;
namespace Assignment_03A
{
    class LargestNumberChecker
    {
        static void Main(string[] args)
        {
            // Declare variables to store the three input numbers
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            // Check and display which number is the largest
            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine($"Is the first number the largest? Yes");
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine($"Is the second number the largest? Yes");
            }
            else if (number3 > number1 && number3 > number2)
            {
                Console.WriteLine($"Is the third number the largest? Yes");
            }
            else
            {
                Console.WriteLine("Two or more numbers are equal and largest.");
            }
        }
    }
}