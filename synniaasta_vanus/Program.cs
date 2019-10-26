using System;

namespace synniaasta_vanus
{
	class Program
	{
		static void Main(string[] args)
		{
			int yearOfBirth;
			Console.WriteLine("Enter Your year of birth: ");			
			yearOfBirth = Int32.Parse(Console.ReadLine());
			CalculateAge(yearOfBirth);
            Console.ReadLine();
		}

		public static void CalculateAge (int yearOfBirth)
		{
			Console.WriteLine($"You are {2019-yearOfBirth}");
		}
		
	}
}
