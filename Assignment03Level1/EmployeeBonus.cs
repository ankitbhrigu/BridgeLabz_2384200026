using System;

namespace Assignment_03A
{
    class EmployeeBonus
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the salary and years of service
            Console.Write("Enter the employee's salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the employee's years of service: ");
            int yearsOfService = Convert.ToInt32(Console.ReadLine());

            // Check if the years of service is greater than 5
            if (yearsOfService > 5)
            {
                // Calculate the bonus as 5% of the salary
                double bonus = 0.05 * salary;

                // Display the bonus amount
                Console.WriteLine($"The bonus amount is: {bonus}");
            }
            else
            {
                // Display a message if no bonus is applicable
                Console.WriteLine("The employee is not eligible for a bonus.");
            }
        }
    }
}