using System;
namespace TriangleAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
   
            Console.WriteLine("Enter the base of the triangle in centimeters:");
            double baseLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the triangle in centimeters:");
            double height = Convert.ToDouble(Console.ReadLine());

            double areaInSquareCm = 0.5 * baseLength * height;

            double areaInSquareInches = areaInSquareCm / 6.4516;

            Console.WriteLine("The area of the triangle is " + areaInSquareCm + " square centimeters.");
            Console.WriteLine("The area of the triangle in square inches is " + areaInSquareInches + " square inches.");
        }
    }
}