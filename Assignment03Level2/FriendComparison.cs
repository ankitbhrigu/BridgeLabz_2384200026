
using System;

namespace Assignment03Level2
{
    class FriendComparison
    {
        static void Main(string[] args)
        {
            // Declare variables for ages and heights of the 3 friends
            int ageAmar, ageAkbar, ageAnthony;
            double heightAmar, heightAkbar, heightAnthony;

            // Input the ages of the friends
            Console.Write("Enter age of Amar: ");
            ageAmar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter age of Akbar: ");
            ageAkbar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter age of Anthony: ");
            ageAnthony = Convert.ToInt32(Console.ReadLine());

            // Input the heights of the friends
            Console.Write("Enter height of Amar (in cm): ");
            heightAmar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height of Akbar (in cm): ");
            heightAkbar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height of Anthony (in cm): ");
            heightAnthony = Convert.ToDouble(Console.ReadLine());

            // Find the youngest friend (smallest age)
            int youngestAge = Math.Min(ageAmar, Math.Min(ageAkbar, ageAnthony));
            string youngestFriend = "";

            if (youngestAge == ageAmar)
            {
                youngestFriend = "Amar";
            }
            else if (youngestAge == ageAkbar)
            {
                youngestFriend = "Akbar";
            }
            else
            {
                youngestFriend = "Anthony";
            }

            // Display the youngest friend
            Console.WriteLine($"The youngest friend is {youngestFriend} with age {youngestAge}.");

            // Find the tallest friend (largest height)
            double tallestHeight = Math.Max(heightAmar, Math.Max(heightAkbar, heightAnthony));
            string tallestFriend = "";

            if (tallestHeight == heightAmar)
            {
                tallestFriend = "Amar";
            }
            else if (tallestHeight == heightAkbar)
            {
                tallestFriend = "Akbar";
            }
            else
            {
                tallestFriend = "Anthony";
            }

            // Display the tallest friend
            Console.WriteLine($"The tallest friend is {tallestFriend} with height {tallestHeight} cm.");
        }
    }
}

