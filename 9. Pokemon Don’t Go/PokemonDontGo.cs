using System;
using System.Collections.Generic;
using System.Text;

namespace _9._Pokemon_Don_t_Go
{
	class PokemonDontGo
	{
		public static void PokemonDontGo1(List<int> numbers, int removedElementValue)
		{
			for (int i = 0; i < numbers.Count; i++)
			{
				if (numbers[i] <= removedElementValue)
				{
					numbers[i] += removedElementValue;
				}
				else
				{
					numbers[i] -= removedElementValue;
				}
			}
		}
	}
}
