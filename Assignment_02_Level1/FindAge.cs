using System;
namespace FindAge{
	class Program{
		public static void Main(string [] args){

			int BirthYear;
			int CurrentYear;
                int age;

                 BirthYear = 2000;
                 CurrentYear = 2024;

			age = CurrentYear - BirthYear;

			Console.WriteLine("Harry's age in 2024 is " + age);	
		}
	}
}