using System;

namespace Homework4
{
	class Program
	{
		//Homework
		static void Main(string[] args)
		{
			UserInput user = new UserInput();
			user.X = user.GetUserNumber();
			user.Y = user.GetUserNumber();
			user.Z = user.GetUserNumber();
			user.U = user.GetUserNumber();
			UserInput.GetMaxValue(user.X, user.Y, user.Z, user.U);
			UserInput.GetMinValue(user.X, user.Y, user.Z, user.U);
			Console.WriteLine(user.TrySumIfOdd(user.X, user.Y, out user.sum));
			user.userString = user.GetUserString();
			user.Repeat(user.userString, user.X);
			Console.Read();
		}
	}

	class UserInput
	{
		public int X;
		public int Y;
		public int Z;
		public int U;
		public bool sum;
		public string userString { get; set; }
		//Method of getting number from user
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

		//Method of getting string from user
		public string GetUserString()
		{
			string userInput;
			Console.WriteLine("Hi, Booriachok! Enter some string: ");
			userInput = Console.ReadLine();
			return userInput;
		}

		//Methods for getting max value
		public static int GetMaxValue(int X, int Y)
			{
			int maxPair;
			maxPair = Math.Max(X, Y);
			Console.WriteLine($"Max number of {X}, {Y} is {maxPair}");
			return maxPair;
			}
		
		public static int GetMaxValue(int X, int Y, int Z) 
		{
			int maxPair;
			maxPair = Math.Max(X, Y);
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
			maxPair = Math.Max(maxPair1, maxPair2);
			Console.WriteLine($"Max number of {X}, {Y}, {Z} and {U} is {maxPair}");
			return maxPair;
		}

		//Methods for getting min value
		public static int GetMinValue(int X, int Y)
		{
			int minPair;
			minPair = Math.Min(X, Y);
			Console.WriteLine($"Min number of {X}, {Y} is {minPair}");
			return minPair;
		}

		public static int GetMinValue(int X, int Y, int Z)
		{
			int minPair;
			minPair = Math.Min(X, Y);
			minPair = Math.Min(minPair, Z);
			Console.WriteLine($"Min number of {X}, {Y} and {Z} is {minPair}");
			return minPair;
		}

		public static int GetMinValue(int X, int Y, int Z, int U)
		{
			int minPair;
			int minPair1;
			int minPair2;
			minPair1 = Math.Min(X, Y);
			minPair2 = Math.Min(Z, U);
			minPair = Math.Min(minPair1, minPair2);
			Console.WriteLine($"Minimum number of {X}, {Y}, {Z} and {U} is {minPair}");
			return minPair;
		}

		//Method TrySumIfOdd that accepts 2 parameters
		//and returns true if sum of numbers between inputs is odd,
		//otherwise false, sum return as out parameter
		public bool TrySumIfOdd(int X, int Y, out bool sum) 
		{
			int minimal, maximum;
			minimal = Math.Min(X, Y);
			maximum = Math.Max(X, Y);
			int currentSum = 0;
			if (X == Y)
			{
				Console.WriteLine("Numbers X and Y are equal!");
				sum = false;
				return sum;
			}
			else 
			{
				while (minimal <= maximum)
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

		//Method Repeat that will accept string X and number N and
		//return X repeated N times (e.g. Repeat(‘str’, 3) returns ‘strstrstr’ = ‘str’ three times)
		public string Repeat(string X, int N) 
		{
			if (N <= 0) 
			{
				Console.WriteLine("Please, enter number > 0:");
				N = GetUserNumber();
				Repeat(X, N);
				return "";
			}
			string repeatedString = "";
			while (N > 0) 
			{
				repeatedString += X;
				N--;
			}
			Console.WriteLine(repeatedString);
			return repeatedString;
		}
	}
}
