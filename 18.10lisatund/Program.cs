using System;

namespace _18._10lisatund
{
	class Program
	{
		static void Main(string[] args)
		{
			string userAnswer;
			Console.WriteLine("Are you coming or leaving?");
			userAnswer = Console.ReadLine();

			if (userAnswer.ToLower() == "coming")
			{
				Hello();
			}
			else if (userAnswer.ToLower() == "leaving")
			{
				Goodbye();
				
			}
			else
			{
				Console.WriteLine("Do not be rude!");
			}
			Console.ReadLine();
		}

		public static void Hello()
		{
			Console.WriteLine("Hello");
		}
		public static void Goodbye()
		{
			Console.WriteLine("Goodbye");
		}
	}
}
