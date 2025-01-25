using System;

namespace Assignment04Level2
{
    class EmployeeBonus
    {
        static void Main(string[] args)
        {
            // Arrays to store salary and years of service for each employee
            double[] salaries = new double[10];
            double[] yearsOfService = new double[10];

            // Arrays to store the bonus and new salary for each employee
            double[] bonuses = new double[10];
            double[] newSalaries = new double[10];

            // Variables to store total bonus, total old salary, and total new salary
            double totalBonus = 0.0;
            double totalOldSalary = 0.0;
            double totalNewSalary = 0.0;

            // Loop to take user input for salary and years of service
            for (int i = 0; i < 10; i++)
            {
                bool validInput = false;

                // Get valid input for salary and years of service
                while (!validInput)
                {
                    try
                    {
                        Console.WriteLine($"\nEnter details for Employee {i + 1}:");

                        Console.Write("Enter salary: ");
                        salaries[i] = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter years of service: ");
                        yearsOfService[i] = Convert.ToDouble(Console.ReadLine());

                        // Check if the salary and years of service are positive numbers
                        if (salaries[i] > 0 && yearsOfService[i] >= 0)
                        {
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Error: Salary and years of service must be positive numbers. Please try again.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Invalid input. Please enter valid numbers.");
                    }
                }
            }

            // Loop to calculate bonus, new salary, and total bonus/new salary
            for (int i = 0; i < 10; i++)
            {
                double bonusPercentage = (yearsOfService[i] > 5) ? 0.05 : 0.02; // 5% for > 5 years, 2% otherwise
                bonuses[i] = salaries[i] * bonusPercentage; // Calculate bonus
                newSalaries[i] = salaries[i] + bonuses[i];  // Calculate new salary

                // Accumulate totals
                totalBonus += bonuses[i];
                totalOldSalary += salaries[i];
                totalNewSalary += newSalaries[i];
            }

            // Display the total bonus payout, total old salary, and total new salary
            Console.WriteLine("\nResults:");
            Console.WriteLine($"Total bonus payout: {totalBonus:C}");
            Console.WriteLine($"Total old salary payout: {totalOldSalary:C}");
            Console.WriteLine($"Total new salary payout: {totalNewSalary:C}");

            // Optionally, display the bonus and new salary for each employee
            Console.WriteLine("\nEmployee Details:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Employee {i + 1}: Salary = {salaries[i]:C}, Bonus = {bonuses[i]:C}, New Salary = {newSalaries[i]:C}");
            }
        }
    }
}
