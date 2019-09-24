using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> integers = (Console.ReadLine()).Split().Select(int.Parse).ToList();

			string input = string.Empty;
			
			while ((input=Console.ReadLine()) != "end")
			{
				string[] commands = input.Split().ToArray();

				switch (commands[0])
				{
					case "Delete":
						{
							
							for (int i = 0; i < integers.Count; i++)
							{
								if (integers[i] == int.Parse(commands[1]))
								{
									integers.Remove(integers[i--]);

								}
							}
						}
						break;
					case "Insert":
						{
							integers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
						}
						break;
					
				}
			}

			Console.WriteLine(string.Join(" ", integers));
		}
	}
}
