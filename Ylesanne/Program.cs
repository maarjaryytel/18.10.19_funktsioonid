using System;

namespace Ylesanne
{
	class Program
	{
		static void Main(string[] args)
		{
			//küsib kasutaja käest mingit lauset ja loeb kokku tühikud//

			string userSentence;
			Console.WriteLine(" Enter your sentence: ");
			userSentence = Console.ReadLine();

			CountSpaces(userSentence);
			Console.ReadLine();
		}
		public static void CountSpaces(string sentence)
		{
			int counter = 0;
			foreach (char symbol in sentence)
			{
				if (symbol == ' ')
				{
					counter++;
				}
			}
			Console.WriteLine($"There are {counter} spaces in your sentence");
		}
	}
}
	

