using System;
namespace Assignment_03
{
    class SimpleInterestCalculator
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter the principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the rate of interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the time period (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());

            // Calculating the Simple Interest
            double simpleInterest = (principal * rate * time) / 100;

            // Output
            Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate}, and Time {time} years.");
        }
    }
}