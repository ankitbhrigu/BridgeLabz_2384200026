using System;

namespace SquareSideCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double perimeter, sideLength;

            
            Console.WriteLine("Enter the perimeter of the square:");
            perimeter = Convert.ToDouble(Console.ReadLine());

            sideLength = perimeter / 4;

            Console.WriteLine("The length of the side is " + sideLength + " whose perimeter is " + perimeter);
        }
    }
}