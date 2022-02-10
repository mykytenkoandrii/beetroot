using System;

namespace lesson_4_methods
{
	internal class Program
	{ //classwork
		static void Main(string[] args)
		{
			Console.WriteLine(Factorial(5));
			Console.Read();
		}
		static int Factorial(int x)
		{
			int factorial;
			factorial = 1;
			while (x != 0)
			{
				factorial *= x;
				x--;
			}
			/*for (int i = x; i > 0; i--)
			{
				factorial *= i;
			}*/
			return factorial;
		}
	}
}

