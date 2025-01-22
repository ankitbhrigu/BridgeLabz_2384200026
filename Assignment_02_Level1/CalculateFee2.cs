using System;
namespace CalculateFee2
{
    class Program
    {
        public static void Main(string[] args)
        {
 
            Console.WriteLine("Enter the Student Fee (in INR): ");
            int fee = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the University Discount Percentage:");
            int discountPercent = Convert.ToInt32(Console.ReadLine());

            double discount = (fee * discountPercent) / 100.0;
            double finalFee = fee - discountAmount;

            Console.WriteLine("The discount amount is INR " + discountAmount + " and final discounted fee is INR " + finalFee);
        }
    }
}