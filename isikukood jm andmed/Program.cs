using System;

namespace isikukood_jm_andmed
{
	class Program
	{
		static void Main(string[] args)
		{
			string id;
			Console.WriteLine("Enter your id number: ");
			id = Console.ReadLine();

			bool idValid; // kas id nr pikkus on õige või mitte/
			idValid = CheckIDLentgh(id); //omaette  muutuja mainis//

			if (idValid) // see if kontrollib kas see tingimus on tõene või väär/
			{
				GetGender(id);//nendega kutsutakse tingimus välja
				GetYear(id);
			}
			else
			{
			    Console.WriteLine("Not OK");
			}
			Console.ReadLine();
		}
			   
		//võtab id nr ja sugu//
		public static void GetGender(string idCode)
		{
			int firstNumber = int.Parse(idCode[0].ToString()); //kõigepealt parse stringiks, siis string intiks//
			if (firstNumber == 4 || firstNumber == 6 || firstNumber == 2)  //ik esimene nr on positsioonil 0/
			{
				Console.WriteLine("Hello, Madam");
			}
			else
			{
				Console.WriteLine("Hello, Sir!");
			}
		}

		public static bool CheckIDLentgh(string idCode) //funktsioon peab midagi tagastama ehk 11 nr on isikukoodis, kui nr on rohkem, vähem, siis me ei saa kasutada
		{
			bool isValid; //deklareerisime selle, ei ole see mis üleval on idValid/
			if (idCode.Length == 11)
			{
				isValid = true; //annab väärtus ja tagastab, Kui ta tagastab, siis võin mainis öelda, et idValid =id pikkusega/
			}
			else
			{
				isValid = false;
			}
			return isValid;
		}

		public static void GetYear(string idCode)
		{
			string year = idCode.Substring(1,2); //substring- alamstring//
			string fullYear = $"19{year}";
			Console.WriteLine($"Your year of birth is: {fullYear}");
			//lubab saada sõna seest ühe kindla tingimuse, 2. ja 3. number isikukoodist
		}

	}

}
