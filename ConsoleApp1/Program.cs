using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();


			List<int> wagons = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

			int maxCapacity = int.Parse(Console.ReadLine());

			
			

			while ((input = Console.ReadLine()) != "end")
			{
				int additionalPassengers = 0;
				bool addWagon = false;
				int additionalWagonWithPassengers = 0;

				try
				{
					additionalPassengers = int.Parse(input);
				}
				catch (Exception)
				{
					string[] inputAsArray = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

					additionalWagonWithPassengers = int.Parse(inputAsArray[1]);
					addWagon = true;
				}

				if (!addWagon)
				{

					for (int i = 0; i < wagons.Count; i++)
					{
						if ((additionalPassengers + wagons[i]) <= maxCapacity)
						{
							wagons[i] += additionalPassengers;
							break;
						}
					}
				
				}

				if (addWagon)
				{
					wagons.Add(additionalWagonWithPassengers);
				}
			}

			Console.WriteLine(string.Join(" ", wagons));
		}
	}
}
