using System;
namespace Assignment_03
{
    class AthleteRun
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter the length of side 1 (in meters): ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of side 2 (in meters): ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of side 3 (in meters): ");
            double side3 = Convert.ToDouble(Console.ReadLine());


            double targetDistance = 5000;

            // Calculating the perimeter of the triangle
            double perimeter = side1 + side2 + side3;

            // Calculating the number of rounds 
            double rounds = targetDistance / perimeter;

            // Output
            Console.WriteLine($"The total number of rounds the athlete will run is {rounds:F2} to complete 5 km.");
        }
    }
}