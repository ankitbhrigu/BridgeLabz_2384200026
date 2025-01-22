using System;
namespace EarthVolumeCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            double earthRadius = 6378;
            double kmToMiles = 0.621371;
            double volumeKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(earthRadius, 3);
            double volumeMiles3 = volumeKm3 * Math.Pow(kmToMiles, 3);

            Console.WriteLine("The volume of Earth in cubic kilometers is “ + volumeKm3 + “ and in cubic miles is “ + volumeMiles3);
        }
    }
}