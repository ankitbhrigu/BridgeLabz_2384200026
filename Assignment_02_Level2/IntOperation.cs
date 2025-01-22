using System;
namespace Assignment_03
{
    class IntOperation
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter the value of a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            // Performing integer operations
            int result1 = a + b * c;    
            int result2 = a * b + c;      
            int result3 = c + a / b;   
            int result4 = a % b + c;      

            // Output
            Console.WriteLine($"The results of Int Operations are: {result1}, {result2}, {result3}, and {result4}");
        }
    }
}