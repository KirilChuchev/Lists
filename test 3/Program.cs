using System;
using System.Collections.Generic;
using System.Linq;

namespace test_3
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> a = new List<int>() { 1, 2, 3, 4, 5 };

			int[] b = a.ToArray();

			a.Insert(5, 33);

			Console.WriteLine(string.Join(" ", a));

			List<int> c = b.ToList();

			b[3] = 44;
			//Console.WriteLine(string.Join(" ", b));
			

			List<int> d = new List<int>(b);

			//Console.WriteLine(string.Join(" ", d));
		}
	}
}
