using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace classwork_8_text
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var filePath = "phonebook.csv";
			string content = GetBook(filePath);
			string[] names = content.Split("\n");
			Regex regex = new Regex("^(\\w+);(\\d+)$");

			var book = new (string name, int number)[names.Length];

			for (var index = 0; index < names.Length; index++)
			{
				var item = names[index];
				var match = regex.Match(item);
				book[index].name = match.Groups[1].Value;
				book[index].number = int.Parse(match.Groups[2].Value);
			}
			Console.WriteLine("Please, enter search criteria: ");
			var searchCriteria = Console.ReadLine();
			Console.WriteLine("Searched results: ");
			var searched = Search(searchCriteria, names);
			foreach(var item in searched)
			{
				Console.WriteLine($"{item.name}, {item.number}");
			}
			
			Console.Read();
		}

		static string GetBook(string filePath)
		{
			return File.ReadAllText(filePath);
		}

		static void ToFile((string name, int number)[] content, string filePath)
		{
			string toFile = string.Empty;
			foreach (var item in content)
			{
				toFile += $"{item.name};{item.number}\n";
			}
			File.WriteAllText(filePath, toFile);
		}

		static (string name, int number)[] Search(string searchText, string[] names)
		{
			searchText = searchText.ToString();
			Regex regex = new Regex(@"(?i)\w*"+searchText+"\\w*");
			Regex arrayRegex = new Regex("^(\\w+);(\\d+)$");
			string search = "";
			for (var index = 0; index < names.Length; index++)
			{
				var item = names[index];
				var match = regex.Match(item);
				if (match.Success)
				{
					search += $"{item}\n";
				}
			}
			string[] searchArray = search.Split("\n");

			var newBook = new (string name, int number)[searchArray.Length-1];

			for (var index = 0; index < searchArray.Length-1; index++)
			{
				var item = searchArray[index];
				var match = arrayRegex.Match(item);
				newBook[index].name = match.Groups[1].Value;
				newBook[index].number = int.Parse(match.Groups[2].Value);
			}
			if (newBook.Length == 0)
			{
				Console.WriteLine ("No matches found!");
			}
			return newBook;
		}
	}
}
