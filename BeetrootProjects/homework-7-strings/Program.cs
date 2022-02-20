using System;
using System.Security.Cryptography.X509Certificates;

namespace homework_7_strings
{
	internal class Program
	{
		//"Compare" that will return true if 2 strings are equal, otherwise false, but do not use build-in method
		static bool Compare(string first, string second)
		{
			bool compare = first == second;
			return compare;
		}
		//Analyze that will return number of alphabetic chars in string, digits and another special characters
		static int Analyze(string someString)
		{
			char[] charArray = someString.ToCharArray();
			int count = 0;
			char space = ' ';
			foreach (char i in charArray)
			{
				if (i != space)
				{
					count++;
				}
			}
			return count;
		}
		//Sort that will return string that contains all characters from input string sorted in alphabetical order
		static string Sort(string someString)
		{
			char[] charArray = someString.ToLower().ToCharArray();
			string sortedArray = "";
			for (int i = 0; i < charArray.Length; i++)
			{
				for (int j = i + 1; j < charArray.Length; j++)
				{
					if (charArray[j] < charArray[j - 1])
					{
						while (charArray[j] < charArray[j - 1]) 
						{
							char temp = charArray[j];
							charArray[j] = charArray[j - 1];
							charArray[j - 1] = temp;
							j--;
							if (j == 0) break;
						}
					}	
				}
				sortedArray += charArray[i];
			}
			return sortedArray;
		}
		//Duplicate that will return array of characters that are duplicated in input string (e.g. 'Hello and hi' -> ['h', 'l'])
		static char[] Duplicate(string someString)
		{
			char[] charArray = someString.ToLower().ToCharArray();
			string duplicates = "";
			for (int i = 0; i < charArray.Length; i++)
			{
				int count = 0;
				for (int j = 0; j < charArray.Length; j++)
				{
					if (charArray[i] == charArray[j])
					{
						count++;
						if (count >= 2)
						{
							if (!Char.IsWhiteSpace(charArray[j]) && !duplicates.Contains(charArray[i]))
							{
								duplicates += charArray[j].ToString(); 
							}
						}
					}
				}
			}
			char[] duplicateArray = duplicates.ToCharArray();
			return duplicateArray;
		}

		static void Main(string[] args)
		{
			string first = "This is one of the same strings with special char*!%",
				second = "This is one of the same strings with special char*!%",
				third = "Something", //expected: eghimnost
				four = "   c  s   X & 3|", //6 characters
				five = "Hello and hi"; //expected array: hl

			Console.WriteLine("This is result of Compare with equal strings: " + Compare(first, second));
			Console.WriteLine("This is result of Compare with different strings: " + Compare(third, second));
			Console.WriteLine($"This is Analyze result - amount of characters in '{four}' string: " + Analyze(four));
			Console.WriteLine($"This is result of Sort for word '{third}': " + Sort(third));
			Console.WriteLine($"This is result of Duplicate for string '{five}': ");
			var duplicateArray = Duplicate(five);
			foreach (char i in duplicateArray)
			{
				Console.Write($"{i}");
			}
			
			Console.Read();
		}
	}

}
