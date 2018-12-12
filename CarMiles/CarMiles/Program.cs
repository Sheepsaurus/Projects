using System;
using System.Linq;

namespace CarMiles
{
	static class Program
	{
		static void Main()
		{
			Test t = new Test();
			Console.WriteLine(t.samletMiles(t.startMetode()));
		}
	}
	class Test
	{
		public Bil[] startMetode()
		{
			return new[]{
				new Bil { milesDriven = 300 },
				new Bil { milesDriven = 250 },
				new Bil { milesDriven = 410 },
				new Bil { milesDriven = 243 }
			};
		}

		public int samletMiles(Bil[] arr)
		{
			return arr.Sum(t => t.milesDriven);
		}
	}
	class Bil
	{
		public int milesDriven;
	}
}
