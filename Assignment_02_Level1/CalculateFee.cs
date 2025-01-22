using System;
namespace CalculateFee
{
    class Program
    {
        public static void Main(string[] args)
        {
            int fee = 125000;
            int discountPercent = 10;

            double discount = (fee * discountPercent) / 100.0;
            double finalFee = fee - discountAmount;

            Console.WriteLine("The discount amount is INR " + discountAmount + " and final discounted fee is INR " + finalFee);
        }
    }
}