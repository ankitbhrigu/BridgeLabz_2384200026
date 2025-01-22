using System;
namespace HeightConverter
{
    class Program
    {
        static void Main(string[] args)
        {
 
            double heightInCm;
            double heightInInches;
            int heightInFeet;
            double remainingInches;

            const double cmToInch = 2.54;
            const int inchesPerFoot = 12;

            Console.WriteLine("Enter your height in centimeters:");
            heightInCm = Convert.ToDouble(Console.ReadLine());

            heightInInches = heightInCm / cmToInch;

            heightInFeet = (int)(heightInInches / inchesPerFoot);
            remainingInches = heightInInches % inchesPerFoot;

            Console.WriteLine("Your height in cm is " + heightInCm + " while in feet it is " + heightInFeet + " feet and " + remainingInches + " inches.");
        }
    }
}