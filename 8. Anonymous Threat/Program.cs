using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Anonymous_Threat
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			List<string> strings = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

			string input2 = string.Empty;

			while ((input2 = Console.ReadLine()) != "3:1")
			{
				string[] commands = input2.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

				string temp = string.Empty;

				switch (commands[0])
				{
					case "merge":
						{
							if (int.Parse(commands[1]) < 0 && int.Parse(commands[2]) >=0 && int.Parse(commands[2]) < strings.Count)
							{
								for (int i = 0; i <= int.Parse(commands[2]); i++)
								{
									temp += strings[i];
								}

								for (int i = 0; i <= int.Parse(commands[2]); i++)
								{
									strings.RemoveAt(0);
								}

								strings.Insert(0, temp);

							}
							else if (int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) < strings.Count && int.Parse(commands[2]) >= strings.Count)
							{
								for (int i = int.Parse(commands[1]); i < strings.Count; i++)
								{
									temp += strings[i];
								}

								for (int i = int.Parse(commands[1]); i < strings.Count; i++)
								{

									strings.RemoveAt(i);
									i--;
								}

								strings.Insert(int.Parse(commands[1]), temp);
							}
							else if (int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) < strings.Count && int.Parse(commands[2]) >= 0 && int.Parse(commands[2]) < strings.Count)
							{
								for (int i = int.Parse(commands[1]); i <= int.Parse(commands[2]); i++)
								{
									temp += strings[i];
								}

								for (int i = int.Parse(commands[1]); i <= int.Parse(commands[2]); i++)
								{
									strings.RemoveAt(int.Parse(commands[1]));
								}

								strings.Insert(int.Parse(commands[1]), temp);
							}
							else if (int.Parse(commands[1]) < 0 && int.Parse(commands[2]) >= strings.Count)
							{
								for (int i = 0; i < strings.Count; i++)
								{
									temp += strings[i];
								}

								for (int i = 0; i < strings.Count; i++)
								{
									strings.RemoveAt(0);
									i--;
								}

								strings.Insert(0, temp);
							}
							else
							{
								continue;
							}
						}
						break;
					case "divide":
						{
							temp = strings[int.Parse(commands[1])];
							//Console.WriteLine(temp);

							if (int.Parse(commands[2]) == 0)
							{
								continue;
							}

							if (temp.Length % int.Parse(commands[2]) == 0)
							{
								strings.RemoveAt(int.Parse(commands[1]));
								int partitionLength = temp.Length / int.Parse(commands[2]);

								for (int i = 0; i < int.Parse(commands[2]); i++)
								{
									string temp1 = string.Empty;
									for (int j = 0; j < partitionLength; j++)
									{
										temp1 += temp[j].ToString();

									}
									temp = temp.Remove(0, partitionLength);

									//Console.WriteLine(temp);
									//temp1 += " ";
									//Console.WriteLine(temp1);
									strings.Insert(int.Parse(commands[1]) + i, temp1);

								}
							}
							else
							{
								strings.RemoveAt(int.Parse(commands[1]));
								int partitionLength = -1;
								
								
									partitionLength = temp.Length / int.Parse(commands[2]);
									for (int i = 0; i < int.Parse(commands[2]) - 1; i++)
									{
										string temp1 = string.Empty;
										for (int j = 0; j < partitionLength; j++)
										{
											temp1 += temp[j].ToString();

										}
										temp = temp.Remove(0, partitionLength);

										//Console.WriteLine(temp);
										//if (i != int.Parse(commands[2]))
										//{
										//	temp1 += " ";
										//}

										//Console.WriteLine(temp1);
										strings.Insert(int.Parse(commands[1]) + i, temp1);

									}
									strings.Insert(int.Parse(commands[1]) + int.Parse(commands[2]) - 1, temp);
							}
						}
						break;

					default:
						break;
				}
			}

			Console.Write(string.Join(" ", strings));
			Console.WriteLine();
		}
	}
}
