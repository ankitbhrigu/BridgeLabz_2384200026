using System;
namespace KilometerToMileConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double km;
            double miles;
            double convertInMiles = 1.6;

            Console.WriteLine("Enter the distance in kilometers:");
            km = Convert.ToDouble(Console.ReadLine());

            miles = km / convertInMiles;

            Console.WriteLine("The total miles is " + miles + " mile(s) for the given " + kilometers + " km.");
        }
    }
}