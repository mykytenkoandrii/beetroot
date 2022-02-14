using System;

namespace Lesson_6_arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const int N = 10;
			int[] array = new int[N];
			int[] array1 = { 1, 2, 3, 4, 5 };
			int[] array2 = new[] { 124, 255, 312, 4, 0 };

			array[0] = 18;
			array[1] = 34;
			array[6] = 12;
			for (int i = 0; i < N; i++)
			{
				array[i] = i;
			}
			for (int i = 0; i < N; i++)
			{
				Console.WriteLine($"{i} item of {array[i]}");
			}

			Console.WriteLine("--------------------------------");
			for (int i = 0; i < array1.Length; i++)
			{
				Console.WriteLine($"{i} item of array1 {array1[i]}");
			}

			Console.WriteLine("--------------------------------");
			int a = 0;
			foreach (int item in array2)
			{
				Console.WriteLine($"{a++} Item of array2 is {item}");
			}

			Console.WriteLine("--------------------------------");
			var copyArray = Copy(array);
			foreach (int item in copyArray)
			{
				Console.WriteLine($"Copy of array is {item}");
			}

			Console.WriteLine("--------------------------------");
			MultipleByNumber(array, 2);
			foreach (int item in array)
			{
				Console.WriteLine($"Item of array is {item}");
			}

			Console.WriteLine("--------------------------------");

			foreach (int x in InitArray(10, 20))
			{
				Console.WriteLine($"Item of someArray is {x}");
			}

			var random = new Random();
			int[] randomArray = new int[N];
			for (int i = 0; i < N; i++)
			{
				randomArray[i] = random.Next(100);
			}
			Console.WriteLine("--------------------------------");
			foreach (int x in randomArray)
			{
				Console.WriteLine($"Item of randomArray is {x}");
			}
			Console.WriteLine("--------------------------------");
			foreach (int x in BubbleSort(randomArray))
			{
				Console.WriteLine($"Item of sorted randomArray is {x}");
			}
		}
		static int[] MultipleByNumber(int[] array, int multiplier)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] *= multiplier;
			}
			return array;
		}
		static int[] Copy(int[] array)
		{
			int[] copy = new int [array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				copy[i] = array[i];
			}
			return copy;
		}

		static int[] InitArray(int a, int b)
		{
			int[] newArray = new int[b-a];
			for (int i = 0; i < newArray.Length; i++)
			{
				newArray[i] = a++;
			}
			return newArray;
		}

		
		static int[] BubbleSort(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array.Length - 1; j++)
				{
					if (array[j] > array[j + 1])
					{
						int temp = array[j];
						array[j] = array[j + 1];
						array[j + 1] = temp;
					}
				}
			}
			return array;
		}
	}
}
