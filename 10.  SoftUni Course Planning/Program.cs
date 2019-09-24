using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.__SoftUni_Course_Planning
{
	class Program
	{
		

		static void Main(string[] args)
		{
			List<string> courseElements = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

			string input = string.Empty;
			string templateForExercise = "{0}-{1}";

			while ((input = Console.ReadLine()) != "course start")
			{
				string[] commands = input.Split(":").ToArray();

				switch (commands[0])
				{
					case "Add":
						{
							if (!(courseElements.Contains(commands[1])))
							{
								courseElements.Add(commands[1]);

								//Console.WriteLine("Add ->" + " " + string.Join(" ", courseElements));
							}
						}
						break;
					case "Insert":
						{
							if (!(courseElements.Contains(commands[1])))
							{
								courseElements.Insert(int.Parse(commands[2]), commands[1]);

								//Console.WriteLine("Insert ->" + " " + string.Join(" ", courseElements));
							}
						}
						break;
					case "Remove":
						{
							if ((courseElements.Contains(commands[1])))
							{
								courseElements.Remove(commands[1]);
							}

							if ((courseElements.Contains(string.Format(templateForExercise, commands[1], "Exercise"))))
							{
								courseElements.Remove(string.Format(templateForExercise, commands[1], "Exercise"));
							}

							//Console.WriteLine("Remove ->" + " " + string.Join(" ", courseElements));
						}
						break;
					case "Swap":
						{
							bool exerciseOne = false;
							bool exerciseTwo = false;

							if (courseElements.Contains(commands[1]) && courseElements.Contains(commands[2]))
							{
								if (courseElements.Contains(string.Format(templateForExercise, commands[1], "Exercise")))
								{
									exerciseOne = true;
								}

								if (courseElements.Contains(string.Format(templateForExercise, commands[2], "Exercise")))
								{
									exerciseTwo = true;
								}

								if (exerciseOne && exerciseTwo)
								{
									int IndexOne = courseElements.IndexOf(commands[1]);
									int IndexTwo = courseElements.IndexOf(commands[2]);
									courseElements[IndexOne] = commands[2];
									courseElements[IndexTwo] = commands[1];
									courseElements[IndexOne + 1] = string.Format(templateForExercise, commands[2], "Exercise");
									courseElements[IndexTwo + 1] = string.Format(templateForExercise, commands[1], "Exercise");
								}
								else if (exerciseOne)
								{
									int IndexOne = courseElements.IndexOf(commands[1]);
									int IndexTwo = courseElements.IndexOf(commands[2]);
									courseElements[IndexOne] = commands[2];
									courseElements[IndexTwo] = commands[1];
									courseElements.Remove(string.Format(templateForExercise, commands[1], "Exercise"));
									IndexTwo = courseElements.IndexOf(commands[1]);
									courseElements.Insert(IndexTwo + 1, string.Format(templateForExercise, commands[1], "Exercise"));

								}
								else if (exerciseTwo)
								{
									int IndexOne = courseElements.IndexOf(commands[1]);
									int IndexTwo = courseElements.IndexOf(commands[2]);
									courseElements[IndexOne] = commands[2];
									courseElements[IndexTwo] = commands[1];
									courseElements.Remove(string.Format(templateForExercise, commands[2], "Exercise"));
									IndexOne = courseElements.IndexOf(commands[2]);
									courseElements.Insert(IndexOne + 1, string.Format(templateForExercise, commands[2], "Exercise"));
								}
								else
								{
									int IndexOne = courseElements.IndexOf(commands[1]);
									int IndexTwo = courseElements.IndexOf(commands[2]);
									courseElements[IndexOne] = commands[2];
									courseElements[IndexTwo] = commands[1];
								}
							}

							//Console.WriteLine("Swap ->" + " " + string.Join(" ", courseElements));
						}
						break;
					case "Exercise":
						{
							if (courseElements.Contains(commands[1]) && !(courseElements.Contains(string.Format(templateForExercise, commands[1], "Exercise"))))
							{
								int tempIndex = courseElements.IndexOf(commands[1]);
								//courseElements[tempIndex] = string.Format(templateForExercise, commands[1], "Exercise");
								courseElements.Insert(tempIndex + 1, string.Format(templateForExercise, commands[1], "Exercise"));
							}
							else if (!(courseElements.Contains(commands[1])) && !(courseElements.Contains(string.Format(templateForExercise, commands[1], "Exercise"))))
							{
								courseElements.Add(commands[1]);
								courseElements.Add(string.Format(templateForExercise, commands[1], "Exercise"));
							}

							//Console.WriteLine("Exercise ->" + " " + string.Join(" ", courseElements));
						}
						break;
					default:
						break;
				}
			}

			string templateForList = "{0}.{1}";

			for (int i = 1; i <= courseElements.Count; i++)
			{
				Console.WriteLine(string.Format(templateForList, i, courseElements[i - 1]));
			}
			
		}
	}
}
