using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopArrayMethods9
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

			string text = new Program().mirrorArray(myArray) ? "The Array IS a Mirror Array" : "The Array IS NOT a Mirror Array";

			Console.WriteLine(text);
			
		}
		

		public bool mirrorArray(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] != arr[arr.Length - 1 - i])
				{
					return false;
				}
			}
			return true;
		}
	}
}
