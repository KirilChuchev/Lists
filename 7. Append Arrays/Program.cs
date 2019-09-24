using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			string[] strings = input.Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
			List<Array> arrays = new List<Array>(strings.Length);

			for (int i = 0; i < strings.Length; i++)
			{
				int[] temp = strings[strings.Length - 1 - i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

				arrays.Insert(i, temp);
			}

			foreach (var item in arrays)
			{
				foreach (var number in item)
				{
					Console.Write(number + " ");
				}
			}
			Console.WriteLine();
		}
	}
}
