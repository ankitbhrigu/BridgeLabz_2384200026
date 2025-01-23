using System;

namespace Assignment_03A
{
    class VotingEligibilityChecker
    {
        static void Main(string[] args)
        {
            // Declare a variable to store the age of the person
            Console.Write("Enter the person's age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Check if the age is 18 or older
            if (age >= 18)
            {
                // Display the result if the person can vote
                Console.WriteLine($"The person's age is {age} and can vote.");
            }
            else
            {
                // Display the result if the person cannot vote
                Console.WriteLine($"The person's age is {age} and cannot vote.");
            }
        }
    }
}