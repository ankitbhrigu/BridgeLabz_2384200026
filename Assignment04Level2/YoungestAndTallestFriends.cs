using System;

namespace Assignment04Level2
{
    class YoungestAndTallestFriends
    {
        static void Main(string[] args)
        {
            // Arrays to store ages and heights for Amar, Akbar, and Anthony
            int[] ages = new int[3];
            double[] heights = new double[3];

            // Friend names for reference
            string[] friends = { "Amar", "Akbar", "Anthony" };

            // Take user input for age and height of each friend
            for (int i = 0; i < 3; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"\nEnter details for {friends[i]}:");

                        // Input age
                        Console.Write("Enter age: ");
                        ages[i] = Convert.ToInt32(Console.ReadLine());

                        // Input height
                        Console.Write("Enter height in cm: ");
                        heights[i] = Convert.ToDouble(Console.ReadLine());

                        // Validate if age and height are reasonable
                        if (ages[i] > 0 && heights[i] > 0)
                            break; // Break the loop if valid input
                        else
                            Console.WriteLine("Error: Age and height must be positive numbers.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Invalid input. Please enter valid numbers.");
                    }
                }
            }

            // Initialize variables to find the youngest and tallest
            int youngestAge = ages[0];
            double tallestHeight = heights[0];
            string youngestFriend = friends[0];
            string tallestFriend = friends[0];

            // Loop to find the youngest and tallest among the three friends
            for (int i = 1; i < 3; i++)
            {
                if (ages[i] < youngestAge) // Compare to find the youngest
                {
                    youngestAge = ages[i];
                    youngestFriend = friends[i];
                }

                if (heights[i] > tallestHeight) // Compare to find the tallest
                {
                    tallestHeight = heights[i];
                    tallestFriend = friends[i];
                }
            }

            // Display the results
            Console.WriteLine($"\nThe youngest friend is {youngestFriend} with age {youngestAge}.");
            Console.WriteLine($"The tallest friend is {tallestFriend} with height {tallestHeight} cm.");
        }
    }
}

