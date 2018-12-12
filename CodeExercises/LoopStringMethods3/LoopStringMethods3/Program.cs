using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopStringMethods3
{
	class Program
	{
		static void Main(string[] args)
		{
			Test t = new Test();
			string a = t.LoopStringMethod("This is strange");
			Console.WriteLine(a);
		}
	}
	public class Test
	{
		public String LoopStringMethod(String s)
		{
			char[] newCharArray = new char[s.Length / 2 + 1];			

			for (int i = 0; i < s.Length; i++)
			{
				if (i % 2 == 0)
				{
					newCharArray[i / 2] = s[i];
				}
			}
			
			return new String(newCharArray);
		}
	}
}
