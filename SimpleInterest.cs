//Self Problems

/* 1. Calculate Simple Interest
Write a program to calculate simple interest using the formula:
Simple Interest = (Principal * Rate * Time) / 100.
Take Principal, Rate, and Time as inputs from the user.
*/

using System;
namespace SimpleInterest{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Principal amount:");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the Rate of interest:");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the Time in years:");
        double time = Convert.ToDouble(Console.ReadLine());
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine("The Simple Interest is: " + simpleInterest);
    }
}
}