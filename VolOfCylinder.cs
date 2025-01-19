//Assisted Problems 

/* 5. Volume of a Cylinder
Write a program to calculate the volume of a cylinder. Take the radius and
height as inputs and use the formula:
Volume = π * radius^2 * height. */


using System;
namespace VolOfCylinder{
	class Program{
		static void Main(string[] args){
			Console.WriteLine("Enter the radius");
			int radius = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the height");
			int height = Convert.ToInt32(Console.ReadLine());
			double volume = (Math.PI * radius * radius * height);
			Console.WriteLine("Volume of cylinder is: " + volume);
		}
	}
}