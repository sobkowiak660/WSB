using System;


namespace _1_first_project
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Imię:");
			Console.WriteLine("Janusz");
			/*komentarz
			 * w
			 * kilku
			 * liniach
			 */

			/*	#
			 *	##
			 *	###
			 */
			Console.WriteLine("#");
				Console.WriteLine("##");
					Console.WriteLine("###");

			Console.WriteLine();

			Console.WriteLine("#\n##\n###");
			Console.WriteLine();
			string name;
			name = "Anna";
			
   Console.WriteLine(name);
			//+ konkatenacja
			Console.WriteLine("Masz na imię: " + name);
			Console.WriteLine("Masz na imię: {0}",name);
			Console.WriteLine();

			int age = 20;
			Console.WriteLine("Masz na imię: {0}, wiek: {1}",name,age );

			sbyte age1 = 20;
			Console.WriteLine("Masz na imię: {0}, wiek: {1}", name, age1);
			Console.ReadKey();
		}
	}
}
