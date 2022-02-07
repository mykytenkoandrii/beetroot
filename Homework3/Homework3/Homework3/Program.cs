using System;

namespace Homework3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool parseAnswer;
			string userInput;
			Console.WriteLine("Hi, booriachok! Enter first num: ");
			userInput = Console.ReadLine();
			parseAnswer = int.TryParse(userInput, out int a);
			if (parseAnswer == false)
			{
				Console.WriteLine("Enter valid integer!: ");
				return;
			}
			Console.WriteLine("Hi, booriachok! Enter second num: ");
			userInput = Console.ReadLine();
			parseAnswer = int.TryParse(userInput, out int b);
			if (parseAnswer == false)
			{
				Console.WriteLine("Enter valid integer!: ");
				return;
			}
			Console.WriteLine("Please  enter num of  arithmetical operations (1 +, 2 -, 3 *, 4/): ");
			userInput = Console.ReadLine();
			parseAnswer = int.TryParse(userInput, out int i);
			if (parseAnswer == false)
			{
				Console.WriteLine("Enter valid integer!: ");
				return;
			}
			switch (i) {
					case 1:
					Console.WriteLine(a + b);
					break;
					case 2:
					Console.WriteLine(a - b);
					break;
					case 3:
					Console.WriteLine(a * b);
					break;
					case 4:
					Console.WriteLine(a / b);
					break;
					default:
					Console.WriteLine("Enter number from 1..4");
					break;
			}
			
			Console.Read();
		}


    }
}
