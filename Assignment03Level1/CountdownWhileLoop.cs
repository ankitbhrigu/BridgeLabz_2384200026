using System;

namespace Assignment_03A
{
    class CountdownWhileLoop
    {
        static void Main(string[] args)
        {
            // Declare a variable to store the user input
            Console.Write("Enter a number to start the countdown: ");
            int counter = Convert.ToInt32(Console.ReadLine());

            // Countdown using a while loop
            while (counter >= 1)
            {
                Console.WriteLine(counter);
                counter--; // Decrement the counter
            }

            Console.WriteLine("Rocket Launch!");
        }
    }
}