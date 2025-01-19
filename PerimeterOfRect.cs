//Self Problems

/* 2. Perimeter of a Rectangle
Write a program to calculate the perimeter of a rectangle. Take the length
and width as inputs and use the formula:
Perimeter = 2 * (length + width). */

using System;
namespace PerimeterOfRect{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of the rectangle:");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the width of the rectangle:");
        double width = Convert.ToDouble(Console.ReadLine());
        double perimeter = 2 * (length + width);
        Console.WriteLine("The Perimeter of the rectangle is: " + perimeter);
    }
}
}