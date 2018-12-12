using System;
using System.IO;

namespace FilePath
{
	class Program
	{
		static void Main(string[] args)
		{
			Program p = new Program();
			string filePathName = "Main";
			string path = $"C:\\Users\\Sheep\\Downloads\\TestFolder\\{filePathName}.txt";

			while (true)
			{
				Console.Write(":>");
				string input = Console.ReadLine();

				switch (input.ToLower().Trim())
				{
					case "/showall":
						p.ShowAll(path);
						break;
					case "/help":
						p.Help();
						break;
					case "/quit":
						Environment.Exit(0);
						break;
					case "/switch":
						p.SwitchFile(filePathName, path);
						break;
					case "/clear":
						p.ClearFile(path, new Program());
						break;
					default:
						File.AppendAllText(path, input + "\n");
						break;
				}
			}
		}
		public void ShowAll(string a)
		{
			Console.WriteLine("The following are your already entered items: \n");
			Console.WriteLine(File.ReadAllText(a));
		}

		public void Help()
		{
			Console.WriteLine("/showall - Shows your current list");
			Console.WriteLine("/clear - Clears your current list");
			Console.WriteLine("/switch - Switches to another file of your choice");
			Console.WriteLine("/quit - Quits the console application");
			Console.WriteLine("/help - Shows this list of commands");
		}

		public void ClearFile(string a, Program b)
		{
			Console.WriteLine("Are you sure you want to clear your list? (Y/N):");
			string stringInputLowered = Console.ReadLine().ToLower();

			if (stringInputLowered == "y")
			{
				File.WriteAllText(a, "");
			}
			else if (stringInputLowered == "n")
			{
				Console.WriteLine("Let me show you your list instead then: ");
				b.ShowAll(a);
			}
		}

		public void SwitchFile(string a, string b)
		{
			Console.WriteLine("Please write the name of your next file:");
			a = Console.ReadLine();
			b = $"C:\\Users\\Sheep\\Downloads\\TestFolder\\{a}.txt";
			File.WriteAllText(b, "");
		}
	}
}
