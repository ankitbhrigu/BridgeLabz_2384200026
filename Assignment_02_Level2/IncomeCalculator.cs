using System;
namespace Assignment_03
{
    class IncomeCalculator
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter the salary (INR): ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the bonus (INR): ");
            double bonus = Convert.ToDouble(Console.ReadLine());

            // Calculating total income
            double totalIncome = salary + bonus;

            // Output
            Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence, Total Income is INR {totalIncome}.");
        }
    }
}