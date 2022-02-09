using System;

namespace Homework4
{
	class Program
	{
		
		static void Main(string[] args)
		{
			UserInput user = new UserInput();
			user.X = 5; //user.GetUserNumber();
			user.Y = 0; //user.GetUserNumber();
			user.Z = 0;         //Console.WriteLine(user.TrySumIfOdd(user.X, user.Y, out user.sum));
			user.U = 0;
			//UserInput.GetMaxValue(user.X, user.Y, user.Z, user.U);
			Console.WriteLine(user.TrySumIfOdd(user.X, user.Y, out user.sum));
			Console.Read();
		}
	}

	class UserInput
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }
		public int U { get; set; }
		public bool sum;
		public int GetUserNumber()
		{
			int userNum;
			string userInput;
			bool parseAnswer;
			Console.WriteLine("Hi, Booriachok! Enter integer number: ");
			userInput = Console.ReadLine();
			parseAnswer = int.TryParse(userInput, out userNum);
			if (parseAnswer == false)
			{
				Console.WriteLine("Enter valid integer!: ");
				return GetUserNumber();
			}
			return userNum;
		}

		public static int GetMaxValue(int X, int Y)
			{
			int maxPair;
			maxPair = Math.Max(X, Y);
			if (X == Y)
			{
				Console.WriteLine($"Numbers {X}, {Y} are equal!");
				return maxPair;
			}
			Console.WriteLine($"Max number of {X}, {Y} is {maxPair}");
			return maxPair;
			}
		public static int GetMaxValue(int X, int Y, int Z) 
		{
			int maxPair;
			maxPair = Math.Max(X, Y);
			if (maxPair == Z) 
			{
				Console.WriteLine("Maximum numbers are equal!");
				return maxPair;
			}
			maxPair = Math.Max(maxPair, Z);
			Console.WriteLine($"Max number of {X}, {Y} and {Z} is {maxPair}");
			return maxPair;
		}
		public static int GetMaxValue(int X, int Y, int Z, int U)
		{
			int maxPair1;
			int maxPair2;
			int maxPair;
			maxPair1 = Math.Max(X, Y);
			maxPair2 = Math.Max(Z, U);
			if (maxPair1 == maxPair2)
			{
				Console.WriteLine("Maximum values are equal!");
				return maxPair1;
			}
			maxPair = Math.Max(maxPair1, maxPair2);
			Console.WriteLine($"Max number of {X}, {Y}, {Z} and {U} is {maxPair}");
			return maxPair;
		}

		public int GetMinValue(int X, int Y)
		{
			return Math.Min(X, Y);
		}
		//Method TrySumIfOdd that accepts 2 parameters
		//and returns true if sum of numbers between inputs is odd,
		//otherwise false, sum return as out parameter
		public bool TrySumIfOdd(int X, int Y, out bool sum) 
		{
			int minimal, maximum;
			minimal = GetMinValue(X, Y);
			maximum = GetMaxValue(X, Y);
			int currentSum = 0;
			if (X == Y)
			{
				Console.WriteLine("Numbers X and Y are equal!");
				sum = false;
				return sum;
			}
			else 
			{
				while (minimal != maximum)
				{
					currentSum += minimal;
					minimal++;
				}
				if (currentSum % 2 == 0)
				{
					sum = false;
					Console.WriteLine($"Sum of nums between {X} and {Y} is {currentSum} and it's pair!");
					return sum;
				}
				sum = true;
				Console.WriteLine($"Sum of nums between {X} and {Y} is {currentSum} and it's odd!");
				return sum;
			}

		}
	}
}
