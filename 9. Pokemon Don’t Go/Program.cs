using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Pokemon_Don_t_Go
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

			int sumRemoved = 0;
			int removedElementValue = 0;

			while (numbers.Count != 0)
			{
				int index = int.Parse(Console.ReadLine());

				if (index < 0)
				{
					removedElementValue = numbers[0];
					sumRemoved += removedElementValue;
					numbers[0] = numbers[numbers.Count - 1];
					
					//PokemonDontGo1(numbers, removedElementValue);
					PokemonDontGo.PokemonDontGo1(numbers, removedElementValue);
					
				}
				else if (index >= numbers.Count)
				{
					removedElementValue = numbers[numbers.Count - 1];
					sumRemoved += removedElementValue;
					numbers[numbers.Count - 1] = numbers[0];

					//PokemonDontGo1(numbers, removedElementValue);
					PokemonDontGo.PokemonDontGo1(numbers, removedElementValue);
				}
				else
				{
					removedElementValue = numbers[index];
					sumRemoved += removedElementValue;
					numbers.RemoveAt(index);

					//PokemonDontGo1(numbers, removedElementValue);
					PokemonDontGo.PokemonDontGo1(numbers, removedElementValue);
				}
			}

			Console.WriteLine(sumRemoved);
		}
	}
}
