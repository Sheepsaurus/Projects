using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StempelRepair
{
	class Program
	{
		static void Main(string[] args)
		{
		}
	}
	
public class Test
	{
		public Bil ReplaceMotor(Bil b)
		{
			Stempel oldStempel = b.m.s;
			b.m = new Motor {s = oldStempel};
			return b;
		}

	}
	public class Bil
	{
		public Motor m;
	}
	public class Motor
	{
		public Stempel s;
		public int HK;
	}
	public class Stempel
	{
		public int Liter;
	}
}
