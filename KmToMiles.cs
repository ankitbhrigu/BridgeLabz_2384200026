// Self Problems

/* 5. Convert Kilometers to Miles
Write a program that takes the distance in kilometers as input from the user
and converts it into miles using the formula:
Miles = Kilometers * 0.621371. */

using System;
namespace KmToMiles{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the distance in kilometers:");
        double kilometers = Convert.ToDouble(Console.ReadLine());
        double miles = kilometers * 0.621371;
        Console.WriteLine("{kilometers} kilometers is equal to" + miles );
    }
}
}