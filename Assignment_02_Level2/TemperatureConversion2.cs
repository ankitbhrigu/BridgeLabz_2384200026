using System;
namespace Assignment_03
{
    class TemperatureConversion2
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter the temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            // Converting Fahrenheit to Celsius
            double celsiusResult = (fahrenheit - 32) * 5 / 9;

            // Output
            Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsiusResult} Celsius.");
        }
    }
}