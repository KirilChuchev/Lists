using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			

			List<string> integers = new List<string>() { "1", "2", "3", "4", "5" };

			//integers.Remove("3");

			integers[2] = "4";
			//integers[3] = "3";

			Console.WriteLine(string.Join(" ", integers));
		
		}
	}
}
