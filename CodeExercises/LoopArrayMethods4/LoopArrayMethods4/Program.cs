using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopArrayMethods4
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] stringArray = { "Mississippi", "Saint Kitts and Nevis", "Seychelles", "Solomon Islands", "South Sudan", "South Africa" };
			Console.WriteLine(new Test().mostLettersInWord(stringArray, 's' ));
			Console.ReadKey();
		}

		public class Test
		{
			public String mostLettersInWord(String[] list, char c)
			{
				String correctWord = "";
				int counter = 0;
				int correctCount = 0;

				for (int i = 0; i < list.Length; i++)
				{
					for (int j = 0; j < list[i].Length; j++)
					{
						if (list[i][j] == c)
						{
							counter++;
						}
					}
					if (correctCount < counter)
					{
						correctWord = list[i];
						correctCount = counter;
					}
					counter = 0;
				}


				return correctWord;
			}
		}
	}
}
