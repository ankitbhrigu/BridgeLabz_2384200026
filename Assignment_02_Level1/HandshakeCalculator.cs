using System;
namespace HandshakeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents;

            Console.WriteLine("Enter the number of students:");
            numberOfStudents = Convert.ToInt32(Console.ReadLine());

            int maximumHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

            Console.WriteLine("The maximum number of possible handshakes among + " numberOfStudents + " students is: " +  maximumHandshakes);
        }
    }
}