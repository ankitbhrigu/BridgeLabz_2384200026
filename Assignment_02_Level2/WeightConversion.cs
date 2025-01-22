using System;
namespace Assignment_03
{
    class WeightConversion
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter the weight in pounds: ");
            double weightInPounds = Convert.ToDouble(Console.ReadLine());

            // Conversion
            double weightInKg = weightInPounds * 2.2;

            // Output
            Console.WriteLine($"The weight of the person in pounds is {weightInPounds} and in kg is {weightInKg}.");
        }
    }
}