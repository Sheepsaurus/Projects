using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMethods2
{
	class Program
	{
		static void Main(string[] args)
		{
			Test t = new Test();

			Console.WriteLine(t.D("so"));
			Console.WriteLine(t.D("yes"));
			Console.WriteLine(t.E("book"));
			Console.WriteLine(t.F("flying"));
			Console.WriteLine(t.F("i"));
		}
	}

    class Test
	{

		public bool D(String a)
		{
			if (a == "yes")
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public char E(String a)
		{
			return a[a.Length];
		}

		public string F(String a)
		{

			if (a.Length > 1)
			{
				return "" + a[a.Length] + a[0];
			}
			else
			{
				return a;
			}

		}

	}
}
