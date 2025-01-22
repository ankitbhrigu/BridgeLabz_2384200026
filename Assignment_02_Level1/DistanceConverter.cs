using System;
namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
        
            double distanceInFeet, distanceInYards, distanceInMiles;

            Console.WriteLine("Enter the distance in feet:");
            distanceInFeet = Convert.ToDouble(Console.ReadLine());

            distanceInYards = distanceInFeet / 3;

            distanceInMiles = distanceInYards / 1760;  

            Console.WriteLine("The distance of " + distanceInFeet + " feet is equivalent to: ");
            Console.WriteLine("Distance in yards: " + distanceInYards + " yards");
            Console.WriteLine("Distance in miles: " + distanceInMiles + " miles");
        }
    }
}