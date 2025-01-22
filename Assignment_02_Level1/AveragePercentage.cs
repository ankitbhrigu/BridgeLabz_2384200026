using System;
namespace AveragePercentage
{
    class Program
    {
        public static void Main(string[] args)
        {
            int mathsMark = 94;
            int physicsMark = 95;
            int chemistryMark = 96;
            int totalMarksObtained = mathsMark + physicsMark + chemistryMark;
            int numberOfSubjects = 3;
            int averageMark = totalMarksObtained / numberOfSubjects;
            Console.WriteLine("Sam's average mark in PCM is: " + averageMark);
        }
    }
}