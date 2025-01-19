// Self Problems

/* 4. Calculate Average of Three Numbers
Write a program that takes three numbers as input from the user and prints
their average. */


using System;
namespace Average{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        double number2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the third number:");
        double number3 = Convert.ToDouble(Console.ReadLine());
        double average = (number1 + number2 + number3) / 3;
        Console.WriteLine("The average of the three numbers is: " + average);
    }
}
}