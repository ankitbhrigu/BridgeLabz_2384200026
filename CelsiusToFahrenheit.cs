//Assisted Problems 

/* 3. Celsius to Fahrenheit Conversion
Write a program that takes the temperature in Celsius as input and converts
it to Fahrenheit using the formula:
Fahrenheit = (Celsius * 9/5) + 32. */


using System;
namespace CelsiusToFahrenheit{
	class Program{
		static void Main(string [] args){
			Console.WriteLine("Enter the temperature in celcius");
			int celsius = Convert.ToInt32(Console.ReadLine());
			double fahrenheit = ((celsius * 9.0/5) + 32);
			Console.WriteLine("Temperature in fahrenheit is: " + fahrenheit);
		}
	}
}