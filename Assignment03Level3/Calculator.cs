using System;
namespace Assignment03Level3
{
    class Calculator
    {
        static void Main(string[] args)
        {
            // Declare variables
            double first, second;
            string op;

            // Get input for the two numbers and the operator
            Console.Write("Enter the first number: ");
            first = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            second = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator (+, -, *, /): ");
            op = Console.ReadLine();

            // Perform the operation using switch...case
            switch (op)
            {
                case "+":
                    Console.WriteLine("Result: " + (first + second));
                    break;
                case "-":
                    Console.WriteLine("Result: " + (first - second));
                    break;
                case "*":
                    Console.WriteLine("Result: " + (first * second));
                    break;
                case "/":
                    if (second != 0)
                    {
                        Console.WriteLine("Result: " + (first / second));
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Operator.");
                    break;
            }
        }
    }

}
