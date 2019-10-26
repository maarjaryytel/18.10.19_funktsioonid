using System;

namespace sugu_minemas_tulemas
{
	class Program
	{
		static void Main(string[] args)
		{
			string userAnswer;
			string sex;
			Console.WriteLine("Are you coming or leaving?");
			userAnswer = Console.ReadLine();
			Console.WriteLine("What is your gender?");
			sex = Console.ReadLine();

			if (userAnswer.ToLower() == "coming")
			{
				Hello(sex);
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

		public static void Hello(string sex) //see string sex on tühi sõna, see sex lihtsalt broneerib koha sõnele, arvuti hakkab ootama seda male.
		{                                      // see string sex ei salvesta midagi, me hakkame seda kontrollima siin, funktsioon teab, et tulemas on mingit sõna//
											   // kui me ei anna ühtegi sõne, siis arvuti ei tee midagi//
			if (sex == "male")
			{
				Console.WriteLine("Hello, Sir");
			}
			else if (sex == "female")
			{
				Console.WriteLine("Hello, Madam!");
			}
			else
			{
				Console.WriteLine("Sorry, can´t identify you");
			}
		}
		public static void Goodbye()
		{
			Console.WriteLine("Goodbye");
		}
	}
}


