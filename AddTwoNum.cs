//Assisted Problems 

/* 2. Add Two Numbers
Write a program that takes two numbers as input from the user and prints
their sum. */

using System;
namespace AddTwoNum{
	class Program{
		static void Main(string[] args){
			Console.WriteLine("Enter the first number");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the second number");	
			int b = Convert.ToInt32(Console.ReadLine());
			int c = a + b;
			Console.WriteLine("The sum of the two numbers is: " + c);
		}
	}
}