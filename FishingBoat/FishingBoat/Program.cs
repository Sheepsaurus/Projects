using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FishingBoat
{
	class Program
	{
		static void Main(string[] args)
		{
			Timer t = new Timer(TimerCallback, null, 0, 3000);
			new Boat(new[]{ "Gertrude", "Batman", "Swordfish", "Orange", "Svenning" });			
		}

		private static void TimerCallback (object o)
		{
			Console.ReadLine();
			GC.Collect();
		}
	}

	public class Boat
	{
		public List<Fish> fishList = new List<Fish>();
		public Boat(string[] array)
		{
			for (int i = 0; i <= 1000;)
			{
				Random r = new Random();
				int randomNumber = r.Next(1, 25);
				switch (randomNumber)
				{
					case 2:
						Console.WriteLine("\nPRESS K TO CATCH THE FISH");
						Thread.Sleep(3000);
						i++;
						break;
					case 7:
						Console.WriteLine("\nPRESS SPACEBAR TO CATCH THE FISH");
						Thread.Sleep(3000);
						i++;
						break;
					case 12:
						Console.WriteLine("\nPRESS I TO CATCH THE FISH");						
						Thread.Sleep(3000);
						i++;
						break;
					case 17:
						Console.WriteLine("A fish touches your lure, be prepared");
						Thread.Sleep(3000);
						i++;
						break;
					default:
						Console.WriteLine("A fish did not touch your lure");
						Thread.Sleep(3000);
						i++;
						break;
				}

				//System.Threading.Thread.Sleep(3000);
				//fishList.Add(new Fish(array[i]));
				//Console.WriteLine(array[i]);				
			}			
		}
	}

	public class Fish
	{
		public string name;

		public Fish(string name)
		{
			this.name = name;
		}
	}
}

