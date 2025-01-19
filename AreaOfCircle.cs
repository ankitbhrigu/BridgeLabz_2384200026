//Assisted Problems 

/* 4. Area of a Circle
Write a program to calculate the area of a circle. Take the radius as input
and use the formula:
Area = π * radius^2. */


using System;
namespace AreaOfCircle{
	class Program{
		static void Main(string[] args){
			Console.WriteLine(" Enter the radius");
			int radius = Convert.ToInt32(Console.ReadLine());
			double area = Math.PI * radius * radius;
			Console.WriteLine("Area of a circle: " + area);
		}
	}
}