using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace lesson_7_strings
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Є рядок, всі символи ловеркейса перевести в аппер, всі символи з апперкейса перевести в ловеркейс, рядок вводимо через консоль
			string placeholder = "Hello, {0} and {1}";
			string name = "Sergii";
			string hisName = "Alex";
			Console.WriteLine("Hello" + name);
			Console.WriteLine(string.Format("Hello, {0} and {1}", name, hisName));
			Console.WriteLine($"Hello, {name} and {hisName}");
			Console.WriteLine(placeholder, name, hisName);
			var hello = $"Hello, {name} and {hisName}";
			char symbol = hello[0];
			Console.WriteLine(symbol);
			Console.WriteLine(char.IsLetter(symbol));
			Console.WriteLine(char.IsDigit(symbol)); //false
			Console.WriteLine(char.IsUpper(symbol)); //true
			Console.WriteLine(hello.Contains("gii")); //true
			Console.WriteLine(hello.EndsWith("lex")); //true

			var helloPlaceHolder = "Hello ";
			var index = helloPlaceHolder.IndexOf(" ");

			Console.WriteLine("Hello ".Insert(index + 1, name)); //true
			Console.WriteLine($"Hello {name}".Replace(name, hisName)); //true

			Console.WriteLine(hello.PadLeft(40)); //true
			Console.WriteLine(hello.Insert(index + 1, name)); //true
			Console.WriteLine(hello.PadLeft(40).Trim());
			var emptyString = string.Empty;
			const int N = 10;
			for (int i = 0; i < N; i++)
			{
				emptyString += $" {i}";
			}
			Console.WriteLine(emptyString);
			var stringBuilder = new StringBuilder();
			for (int i = 0; i < N; i++)
			{
				stringBuilder.AppendFormat(" {0}", i);
			}
			Console.WriteLine(emptyString);
			Console.WriteLine(stringBuilder.ToString()); //stringBuilder виділяє пам"ять тільки при ToString
		}
	}
	}





