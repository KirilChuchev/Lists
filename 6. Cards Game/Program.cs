using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Cards_Game
{
	class Program
	{
		static void Main(string[] args)
		{
			string input1 = Console.ReadLine();
			string input2 = Console.ReadLine();

			List<int> deck1 = input1.Split(" ").Select(int.Parse).ToList();
			List<int> deck2 = input2.Split(" ").Select(int.Parse).ToList();

			while (deck1.Count != 0 && deck2.Count != 0)
			{

				int count = Math.Min(deck1.Count, deck2.Count);
				for (int i = 0; i < count; i++)
				{
					if (deck1[i] > deck2[i])
					{
						deck1.Add(deck1[i]);
						deck1.Add(deck2[i]);
						deck1.Remove(deck1[i]);
						deck2.Remove(deck2[i]);
					}
					else if (deck1[i] < deck2[i])
					{
						deck2.Add(deck2[i]);
						deck2.Add(deck1[i]);
						deck1.Remove(deck1[i]);
						deck2.Remove(deck2[i]);
					}
					else
					{
						deck1.Remove(deck1[i]);
						deck2.Remove(deck2[i]);
					}

					i--;
					count = Math.Min(deck1.Count, deck2.Count);
				}

				
			}

			if (deck1.Count == 0)
			{
				Console.WriteLine($"Second player wins! Sum: {deck2.Sum()}");
			}
			else if (deck2.Count == 0)
			{
				Console.WriteLine($"First player wins! Sum: {deck1.Sum()}");
			}
		}
	}
}
