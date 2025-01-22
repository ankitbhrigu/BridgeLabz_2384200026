using System;
namespace ConvertIntoMiles
{
    class Program
    {
        public static void Main(string[] args)
        {

            double distanceInKilometers;
            double kilometersToMilesFactor;
            double distanceInMiles;


            distanceInKilometers = 10.8;
            kilometersToMilesFactor = 1.6;
            distanceInMiles = distanceInKilometers * kilometersToMilesFactor;


            Console.WriteLine("The distance 10.8 km in miles is: " + distanceInMiles);
        }
    }
}