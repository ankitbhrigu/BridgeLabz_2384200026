using System;
namespace Assignment_03
{
    class TemperatureConversion
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter the temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            // Converting Celsius to Fahrenheit
            double fahrenheitResult = (celsius * 9 / 5) + 32;

            // Output
            Console.WriteLine($"The {celsius} Celsius is {fahrenheitResult} Fahrenheit.");
        }
    }
}