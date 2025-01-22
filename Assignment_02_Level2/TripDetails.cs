using System;
namespace Assignment_03
{
    class TripDetails
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the starting city: ");
            string fromCity = Console.ReadLine();

            Console.Write("Enter the via city: ");
            string viaCity = Console.ReadLine();

            Console.Write("Enter the destination city: ");
            string toCity = Console.ReadLine();

            // Taking distances in miles
            Console.Write("Enter the distance from the starting city to the via city (miles): ");
            double fromToVia = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the distance from the via city to the destination city (miles): ");
            double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

            // Time taken for the journey
            Console.Write("Enter the total time taken for the journey (in hours): ");
            double timeTaken = Convert.ToDouble(Console.ReadLine());

            // Calculating total distance
            double totalDistance = fromToVia + viaToFinalCity;

            // Displaying the results
            Console.WriteLine($"The results of the trip are: {name}, traveling from {fromCity} via {viaCity} to {toCity} covering a total distance of {totalDistance} miles in {timeTaken} hours.");
        }
    }
}