using System;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 1000; i++)
			{
				Console.WriteLine
				(
					i % 3 == 0 && i % 5 == 0 && i % 7 == 0 ? "FizzBuzz!" :
					i % 3 == 0 && i % 5 == 0 ? "FizzBuzz" :
					i % 7 == 0 ? "!" :
					i % 3 == 0 ? "Fizz" :
					i % 5 == 0 ? "Buzz" :
					i.ToString());
			}

			Console.ReadLine();
		}

		public Tuple<string, int> A(Tuple<string, int> b)
		{
			
			return b;
		}
	}	
}
