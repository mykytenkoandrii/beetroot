using System;
using System.Globalization;
using System.Linq;

namespace Homework5
{
	internal class Program
	{
		public static int[] array = new int[] { 64, 25, 12, 22, 11 };

		enum SortAlgorithmType { BubbleSort, SelectionSort, InsertionSort }

		enum OrderBy { Asc, Desc }

		static void BubbleSort(int[] array, OrderBy type)
		{
			int[] arr = CopyArray(array);
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++) 
				{
					if (type == 0 ? arr[j] > arr[j + 1] : arr[j] < arr[j + 1])
					{
						if (arr[j] > arr[j + 1])
						{
							int temp = arr[j];
							arr[j] = arr[j + 1];
							arr[j + 1] = temp;
						}
					}
				}
			}
			Output(arr);
		}

		static void SelectionSort(int[] array, OrderBy type)
		{
			int[] arr = CopyArray(array);
			for (int i = 0; i < 5; i++)
			{
				int index_minimum = i;
				for (int j = i; j < 5; j++)
				{
					if (type == 0 ? arr[index_minimum] > arr[j] : arr[index_minimum] < arr[j])
					{
						if (arr[index_minimum] > arr[j])
						{
							index_minimum = j;
						}
					}
				}
				int temp = arr[i];
				arr[i] = arr[index_minimum];
				arr[index_minimum] = temp;
			}
			Output(arr);
		}

		static void InsertionSort(int[] array, OrderBy type)
		{
			int[] arr = CopyArray(array);
			for (int i = 1; i < 5; i++)
			{
				int k = i;
				if (type == 0 ? arr[k] < arr[k - 1] : arr[k] > arr[k - 1])
				{
					if (arr[i] < arr[i - 1])
					{
						while (arr[k] < arr[k - 1])
						{
							int temp = arr[k - 1];
							arr[k - 1] = arr[k];
							arr[k] = temp;
							k--;
							if (k - 1 < 0) break;
						}
					}
				}
			}
			Output(arr);
		}

		static int[] CopyArray(int[] array)
		{
			int[] copy = new int[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				copy[i] = array[i];
			}
			return copy;
		}

		static void Output(int[] arr)
		{
			Console.WriteLine($"{arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}");
		}

		static void Sort(int[] array, SortAlgorithmType sort, OrderBy type)
		{
			switch (sort)
			{
				case SortAlgorithmType.BubbleSort:
					BubbleSort(array, type);
					break;
				case SortAlgorithmType.SelectionSort:
					SelectionSort(array, type);
					break;
				case SortAlgorithmType.InsertionSort:
					InsertionSort(array, type);
					break;
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Here's bubble sort order by ascending:");
			Sort(array, SortAlgorithmType.BubbleSort, OrderBy.Asc);
			Console.WriteLine("Here's bubble sort order by descending:");
			Sort(array, SortAlgorithmType.BubbleSort, OrderBy.Desc);
			Console.WriteLine("Here's selection sort order by ascending:");
			Sort(array, SortAlgorithmType.SelectionSort, OrderBy.Asc);
			Console.WriteLine("Here's selection sort order by descending:");
			Sort(array, SortAlgorithmType.SelectionSort, OrderBy.Desc);
			Console.WriteLine("Here's insertion sort order by ascending:");
			Sort(array, SortAlgorithmType.InsertionSort, OrderBy.Asc);
			Console.WriteLine("Here's insertion sort order by descending:");
			Sort(array, SortAlgorithmType.InsertionSort, OrderBy.Desc);
			Console.Read();
		}
	}
	
}
