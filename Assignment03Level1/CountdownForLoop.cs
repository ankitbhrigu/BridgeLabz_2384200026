using System;

namespace Assignment_03A
{
    class CountdownForLoop
    {
        static void Main(string[] args)
        {
            // Declare a variable to store the user input
            Console.Write("Enter a number to start the countdown: ");
            int counter = Convert.ToInt32(Console.ReadLine());

            // Countdown using a for loop
            for (int i = counter; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Rocket Launch!");
        }
    }
}