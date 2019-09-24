using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Bomb_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			List<int> numbers = input.Split(' ').Select(int.Parse).ToList();

			string bomb = Console.ReadLine();
			int[] bombs = bomb.Split(' ').Select(int.Parse).ToArray();

			//int index = numbers.IndexOf(bombs[0]) - bombs[1];
			//int indexConst = index; => записваш тази стойност веднъж и работиш с нея винаги, което е грешно; правилното е долното закоментирано

			for (int i = 0; i < numbers.Count; i++)
			{
				if (numbers[i] == bombs[0])
				{
					int indexConst = i - bombs[1];
					//int indexConst = i;
					for (int j = 0; j < bombs[1] * 2 + 1; j++)
					{
						if (indexConst >= 0 && indexConst < numbers.Count)
						{
							numbers.RemoveAt(indexConst);
						}
						else
						{
							if (indexConst < numbers.Count)
							{
								indexConst++;
							}
							else
							{
								break;
							}
							
							//i++;
						}
					}
					i = 0;
				}
				
			}

			//Console.WriteLine(string.Join(" ", numbers));

			Console.WriteLine(numbers.Sum());
		}
	}
}
