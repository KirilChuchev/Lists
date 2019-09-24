using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._House_Party
{
	class Program
	{
		static void Main(string[] args)
		{
			int commandsCount = int.Parse(Console.ReadLine());

			List<string> guests = new List<string>();

			for (int i = 0; i < commandsCount; i++)
			{
				
				List<string> command = (Console.ReadLine()).Split().ToList();

				if (!(command.Contains("not")))
				{
					if (!(guests.Contains(command[0])))
					{
						guests.Add(command[0]);

						
					}
					else
					{
						guests.Add(command[0]);
						//Console.WriteLine($"{command[0]} is already in the list!");

						
					}
				}
				else
				{
					for (int j = 0; j < guests.Count; j++)
					{
						if (guests[j] == command[0])
						{
							guests.Remove($"{command[0]}");
							//guests.RemoveAt(j);
						}
					}
				}
			}

			foreach (var item in guests)
			{
				Console.WriteLine(item);
			}
		}
	}
}
