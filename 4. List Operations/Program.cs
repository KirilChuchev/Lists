using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			List<int> integers = input.Split().Select(int.Parse).ToList();

			while ((input = Console.ReadLine()) != "End")
			{
				List<string> command = input.Split().ToList();

				switch (command[0])
				{
					case "Add":
						{
							integers.Add(int.Parse(command[1]));
						}
						break;
					case "Insert":
						{
							if (int.Parse(command[2]) >= 0 && int.Parse(command[2]) < integers.Count)
							{
								integers.Insert(int.Parse(command[2]), int.Parse(command[1]));
							}
							else
							{
								Console.WriteLine("Invalid index");
							}
							
						}
						break;
					case "Remove":
						{
							if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < integers.Count)
							{
								integers.RemoveAt(int.Parse(command[1]));
							}
							else
							{
								Console.WriteLine("Invalid index");
							}
							
						}
						break;
					case "Shift":
						{
							if (command[1] == "left")
							{
								for (int i = 0; i < int.Parse(command[2]); i++)
								{
									integers.Add(integers[0]);
									integers.RemoveAt(0);
								}
							}
							else
							{
								for (int i = 0; i < int.Parse(command[2]); i++)
								{
									integers.Insert(0, integers[integers.Count - 1]);
									integers.RemoveAt(integers.Count - 1);
								}
							}
						}
						break;
					default:
						break;
				}

				
			}

			Console.WriteLine(string.Join(" ", integers));

		}
	}
}
