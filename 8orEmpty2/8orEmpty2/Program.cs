using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8orEmpty2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array1 = { 1, 2, 3, 4 };
			int[] array2 = { 4, 3, 2, 1 };

			Program k = new Program();
			k.K(array1, array2);

			Console.ReadLine();
		}
		public int[] K(int[] a, int[] b)
		{
			if (a.Length == 4 && b.Length == 4)
			{
				int[] newArray = new int[8];
				int i = 0;
				while (i < a.Length)
				{
					newArray[i] = a[i];
					i++;
				}
				int j = 0;
				while (j < b.Length)
				{
					newArray[j+4] = b[j];
					j++;
				}
				return newArray;
			}
			else
			{
				int[] newEmptyArray = new int[0];
				return newEmptyArray;
			}
		}
	}
}