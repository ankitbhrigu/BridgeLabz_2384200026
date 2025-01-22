using System;
namespace Assignment_03
{
    class ChocolateDistribution
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter the number of chocolates: ");
            int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of children: ");
            int numberOfChildren = Convert.ToInt32(Console.ReadLine());

            // Calculating chocolates 
            int chocolatesPerChild = numberOfChocolates / numberOfChildren;
            int remainingChocolates = numberOfChocolates % numberOfChildren;

            // Output
            Console.WriteLine($"The number of chocolates each child gets is {chocolatesPerChild} and the number of remaining chocolates is {remainingChocolates}.");
        }
    }
}