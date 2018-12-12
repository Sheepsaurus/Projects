using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8orEmpty
{
	class Program
	{
		public static void Main(string[] args)
		{

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
					newArray[j] = b[j];
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
