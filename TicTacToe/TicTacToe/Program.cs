using System;

namespace TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] myArray = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };

			Program sw = new Program();

			while (1 == 1)
			{
				
				Console.WriteLine("Vælg en Kolonne (1-3)");
				int kolonne = int.Parse(Console.ReadLine());
				Console.WriteLine("Vælg en Række (1-3)");
				int række = int.Parse(Console.ReadLine());
				Console.WriteLine("Vælg enten kryds (x) eller bolle (o)");
				string valg = Console.ReadLine();
				Console.Clear();
				
				switch (kolonne)
				{
					case 1:
						switch (række)
						{
							case 1:
								myArray[0] = char.Parse(valg);
								break;
							case 2:
								myArray[1] = char.Parse(valg);
								break;
							case 3:
								myArray[2] = char.Parse(valg);
								break;
							default:
								break;
						}
						break;
					case 2:
						switch (række)
						{
							case 1:
								myArray[3] = char.Parse(valg);
								break;
							case 2:
								myArray[4] = char.Parse(valg);
								break;
							case 3:
								myArray[5] = char.Parse(valg);
								break;
							default:
								break;
						}
						break;
					case 3:
						switch (række)
						{
							case 1:
								myArray[6] = char.Parse(valg);
								break;
							case 2:
								myArray[7] = char.Parse(valg);
								break;
							case 3:
								myArray[8] = char.Parse(valg);
								break;
							default:
								break;
						}
						break;
					default:
						break;
				}
			}
		}

		public void Swatch (char[] myArray /* char x, char y, char z, int række, string valg */)
		{

			Console.Write(Environment.NewLine);
			Console.Write(Environment.NewLine);
			Console.WriteLine("      -------------");
			Console.WriteLine("      | " + myArray[0] + " |" + " " + myArray[1] + " |" + " " + myArray[2] + " |");
			Console.WriteLine("      -------------");
			Console.WriteLine("      | " + myArray[3] + " |" + " " + myArray[4] + " |" + " " + myArray[5] + " |");
			Console.WriteLine("      -------------");
			Console.WriteLine("      | " + myArray[6] + " |" + " " + myArray[7] + " |" + " " + myArray[8] + " |");
			Console.WriteLine("      -------------");
			Console.Write(Environment.NewLine);
			Console.Write(Environment.NewLine);


			//	switch (række)
			//	{
			//		case 1:
			//			x = char.Parse(valg);
			//			break;
			//		case 2:
			//			y = char.Parse(valg);
			//			break;
			//		case 3:
			//			z = char.Parse(valg);
			//			break;
			//		default:
			//			break;
			//	}
		}
	}
}
