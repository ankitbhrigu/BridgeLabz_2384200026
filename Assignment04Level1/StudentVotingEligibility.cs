using System;
namespace Assignment04Level1{
    class StudentVotingEligibility{
        static void Main(string[] args){
            // Define the number of students in the class
            int totalStudents = 10;

            // Array to store ages of students
            int[] studentAges = new int[totalStudents];

            // Prompt user for input and validate
            Console.WriteLine("Enter the ages of 10 students:");

            for (int i = 0; i < studentAges.Length; i++){
                while (true){
                    // Input age for each student
                    Console.Write($"Enter age for student {i + 1}: ");
                    string userInput = Console.ReadLine();

                    // Validate if the input is a valid integer
                    if (int.TryParse(userInput, out int age))
                    {
                        // Check for non-negative values
                        if (age >= 0)
                        {
                            studentAges[i] = age;
                            break; // Exit the loop if input is valid
                        }
                        else
                        {
                            Console.WriteLine("Error: Age cannot be negative. Please enter a valid age.");
                        }
                    }
                    else{
                        Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
                    } }  }

            // Loop through the array to check voting eligibility
            Console.WriteLine("\nVoting Eligibility Results:");
            for (int i = 0; i < studentAges.Length; i++)
            {
                int age = studentAges[i];
                if (age >= 18)
                {
                    Console.WriteLine($"The student with the age {age} can vote.");
                }
                else
                {
                    Console.WriteLine($"The student with the age {age} cannot vote.");
                }
            }  
}
 }
}