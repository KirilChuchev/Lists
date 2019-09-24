using System;
using System.Collections.Generic;

namespace test_1
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> integers = new List<int>() { 1, 2, 3, 4, 5, 5, 6 };
			List<string> strings = new List<string>() { "1", "2", "3", "4", "5", "5", "6" };

			//for (int i = 0; i < integers.Count; i++)
			//{
			//	if (integers[i] == 5)
			//	{
			//		//integers.Remove(integers[i--]);
			//		integers.RemoveAt(i--);
			//	}
			//}

			//integers.Insert(2, 3333);
			//Console.WriteLine(string.Join(" ", integers));

			//for (int i = 0; i < strings.Count; i++)
			//{
			//	if (strings[i] == "5")
			//	{
			//		strings.Remove("5");
			//		i--;
			//	}
			//}

			string a = "12345";
			a = a.Remove(2, 1);
			//string temp = string.Empty;
			//temp = a[1].ToString();
			Console.WriteLine(a);
			Console.WriteLine(a.Length);

			//Console.WriteLine(string.Join(" ", strings));

			int e = 10;
			try
			{
				e = 5 / int.Parse(Console.ReadLine());
				Console.WriteLine(e + 20);
			}
			catch (Exception)
			{

				Console.WriteLine(e + 100);
			}

			
		}
	}
}
