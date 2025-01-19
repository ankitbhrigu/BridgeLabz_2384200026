// Self Problems

/* 3. Power Calculation
Write a program that takes two numbers as input: a base and an exponent,
and prints the result of base raised to the exponent (without using loops or
conditionals). */


using System;
namespace PowerCal{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the base:");
        double baseNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the exponent:");
        double exponent = Convert.ToDouble(Console.ReadLine());
        double result = Math.Pow(baseNumber, exponent);
        Console.WriteLine("Result is: " + result);
    }
}
}