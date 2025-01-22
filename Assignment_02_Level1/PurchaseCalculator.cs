using System;
namespace PurchaseCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double unitPrice, quantity, totalPrice;

            Console.WriteLine("Enter the unit price of the item (INR):");
            unitPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the quantity to be bought:");
            quantity = Convert.ToDouble(Console.ReadLine());

            totalPrice = unitPrice * quantity;

            Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity is " + quantity + " and the unit price is INR " +  unitPrice);
        }
    }
}