using System;
class BMICalculator{
    static void Main(){
        // For user input
        Console.Write("Enter your weight in kilograms (kg): ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter your height in centimeters (cm): ");
        double heightInCm = double.Parse(Console.ReadLine());

        // Convert height from cm to m
        double heightInMeters = heightInCm / 100;

        // Calculate BMI
        double bmi = weight / (heightInMeters * heightInMeters);

        string status;
        if (bmi <= 18.4)
        {
            status = "Underweight";
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            status = "Normal";
        }
        else if (bmi >= 25.0 && bmi <= 39.9)
        {
            status = "Overweight";
        }
        else
        {
            status = "Obese";
        }

        // Display the result
        Console.WriteLine($"\nYour BMI is: {bmi:F2}");
        Console.WriteLine($"You are classified as: {status}");
    }
}