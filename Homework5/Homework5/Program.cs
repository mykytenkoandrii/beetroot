using System;
using System.Linq;

namespace Homework5
{
	internal class Program
	{
		public static int[] array = new int[] { 64, 25, 12, 22, 11 };
		//
		static void Selection(int[] arr)
		{

			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++) 
				{
					if (arr[j] < arr[j + 1])
					{
						int temp = arr[j];
						arr[j] = arr[j+1];
						arr[j + 1] = temp;
					}
				}
			}
			foreach (int i in arr)
			{
				Console.WriteLine("{0}", i);
			}
		}



		static void Main(string[] args)
		{
			Selection(array);
			Console.Read();
		}
	}
	
}
