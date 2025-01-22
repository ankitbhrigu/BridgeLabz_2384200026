using System;
namespace ProfitLossCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            int costPrice = 129;
            int sellingPrice = 191;
            int profit = sellingPrice - costPrice;
            float profitPercentage = (float)profit / costPrice * 100;

            Console.WriteLine($@"
The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}
The Profit is INR {profit} and the Profit Percentage is {profitPercentage:F2}%
");
        }
    }
}