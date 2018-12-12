using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods4
{
	class Program
	{
		static void Main(string[] args)
		{
			Test t = new Test();
			Console.WriteLine(t.StringMethod("avnjrkenvjkrenabcgnrjeovnjeoqnjo"));
			
		}
	}
	public class Test
	{
		public int StringMethod(string s)
		{
			if (s.Contains("abc"))
			{
				int i = 0;
				int position = 0;
				while (i < s.Length)
				{
					if (s[i] == 'a' && s[i + 1] == 'b' && s[i + 2] == 'c')
					{
						position = i;
					}
					i++;
				}
				return position;
			}
			else
			{
				return -1;
			}
		}
	}
}
