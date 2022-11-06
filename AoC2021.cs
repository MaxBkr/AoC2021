#region Day1
//string[] text = File.ReadAllLines(@"C:\Users\mbaker\Documents\AoC\2021\Day 1\input.txt");
//string last = "";
//int count = 0;

//foreach (string num in text)
//{
//	if (last != "")
//	{
//		if(Int32.Parse(num) > Int32.Parse(last))
//		{
//			count++;
//		}
//	}
//	last = num;
//}

//Console.WriteLine(count);
//Console.ReadLine();


//List<int> sums = new List<int>();
//for (int i = 0; i < text.Length-3; i++)
//{
//	sums.Add(Int32.Parse(text[i])+Int32.Parse(text[i+1])+ Int32.Parse(text[i+2]));
//}

//int lastsum = 0;
//int countsum = 0;

//foreach (int num in sums)
//{
//	if (num > lastsum)
//	{
//		countsum++;
//	}
//	lastsum = num;
//}

//Console.WriteLine(countsum);
//Console.ReadLine();
#endregion Day1

#region Day2
//string[] text = File.ReadAllLines(@"C:\Users\mbaker\Documents\AoC\2021\Day 2\input.txt");

//int height = 0;
//int depth = 0;
//int aim = 0;

//foreach (string line in text)
//{
//	string[] splitLine = line.Split(" ");
//	if (splitLine[0] == "forward")
//	{
//		height = height + int.Parse(splitLine[1]);
//		depth = depth + (aim * int.Parse(splitLine[1]));
//	}
//	else if (splitLine[0] == "down")
//	{
//		aim = aim + int.Parse(splitLine[1]);
//	}
//	else if (splitLine[0] == "up")
//	{
//		aim = aim - int.Parse(splitLine[1]);
//	}
//	else
//	{
//		Console.WriteLine("ERROR - line is:");
//		Console.WriteLine(line);
//	}
//}

//Console.WriteLine(depth * height);
//Console.ReadLine();
#endregion Day2

#region Day3
// Part 1
//string[] text = File.ReadAllLines(@"C:\Users\mbaker\Documents\AoC\2021\Day 3\input.txt");
//int[] results = new int[text[0].Length];
//char[] gamma = new char[text[0].Length];
//char[] epsilon = new char[text[0].Length];

//for (int i = 0; i < text.Length; i++)
//{
//	for (int j = 0; j < text[i].Length; j++)
//	{
//		if (text[i][j] == '1')
//		{
//			results[j]++;
//		}
//	}
//}

//for (int i = 0; i < results.Length; i++)
//{
//	int result = results[i];
//	int temp = text.Length - result;
//	if (temp > text.Length / 2)
//	{
//		gamma[i] = '1';
//		epsilon[i] = '0';
//	}
//	else
//	{
//		gamma[i] = '0';
//		epsilon[i] = '1';
//	}
//}

//foreach (char c in gamma)
//{
//	Console.WriteLine(c);
//}

//Console.WriteLine(gamma.ToString());

//int g = Convert.ToInt32(new string(gamma), 2);
//int e = Convert.ToInt32(new string(epsilon), 2);

//Console.WriteLine(gamma.ToString());
//Console.WriteLine(g*e);
//Console.ReadLine();

// Part 2
//var o2Rating = CalculateRating(RatingType.o2);
//Console.WriteLine(o2Rating);
//var co2Rating = CalculateRating(RatingType.co2);
//Console.WriteLine(co2Rating);
//Console.WriteLine(o2Rating * co2Rating);
//Console.ReadLine();

//int CalculateRating(RatingType type)
//{
//	List<string> input = File.ReadAllLines(@"C:\Users\mbaker\Documents\AoC\2021\Day 3\input.txt").ToList();
//	var i = 0;
//	while (input.Count > 1)
//	{
//		var groups = input
//			.Select(x => x[i])
//			.GroupBy(x => x)
//			.OrderByDescending(x => x.Count());
//		bool sameAmount = groups.First().Count() == groups.ElementAt(1).Count();
//		char bit = type switch
//		{
//			RatingType.o2 => sameAmount ? '1' : groups.First().Key,
//			RatingType.co2 => sameAmount ? '0' : groups.ElementAt(1).Key,
//			_ => throw new NotImplementedException(),
//		};
//		input.RemoveAll(x => x[i] != bit);
//		i++;
//	}
//	return Convert.ToInt32(input.FirstOrDefault(), 2);
//}

//internal enum RatingType
//{
//	o2,
//	co2
//}

#endregion Day3

#region Day4

//string[] text = File.ReadAllLines(@"C:\Users\mbaker\Documents\AoC\2021\Day 4\input.txt");

//List<string> numbersList = text[0].Split(',').ToList<string>();
//List<int[,]> cardList = new List<int[,]>();


//for (int i = 2; i < text.Length; i += 6)
//{
//	int[,] tempArray = new int[5, 5];
//	for (int j = 0; j < 5; j++)
//	{
//		List<string> tempLine = text[i+j].Split(' ').ToList<string>();
//		tempLine = tempLine.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
//		for (int x = 0; x < 5; x++)
//		{
//			tempArray[j, x] = int.Parse(tempLine[x]);
//		}
//	}
//	cardList.Add(tempArray);
//}

//bool BINGO = false;
//int numberPos = 0;
//int ans = -1;
//int num = -1;
//int[] bingoed = new int[cardList.Count];

//while (bingoed.Contains(0))
//{
//	for (int x = 0; x < cardList.Count; x++)
//	{
//		for (int i = 0; i < 5; i++)
//		{
//			for (int j = 0; j < 5; j++)
//			{
//				if (cardList[x][i,j] == int.Parse(numbersList[numberPos]))
//				{
//					cardList[x][i, j] = -1;
//				}
//			}
//		}
//		if (findBingo(cardList[x]) && !BINGO)
//		{
//			num = int.Parse(numbersList[numberPos]);
//			bingoed[x] = 1;
//		}
//	}
//	numberPos++;

//	foreach (int val in bingoed)
//	{
//		Console.Write(val);
//	}
//	Console.WriteLine();
//}

//ans = 8;

//int total = 0;

//for (int i = 0; i < 5; i++)
//{
//	for (int j = 0; j < 5; j++)
//	{
//		if (cardList[ans][i, j] != -1)
//		{
//			total += cardList[ans][i, j];
//		}
//	}
//}

//Console.WriteLine(total*num);
//Console.ReadLine();



//bool findBingo(int[,] array)
//{
//	// Horizontally
//	for (int i = 0; i < 5; i++)
//	{
//		bool found = true;
//		for (int j = 0; j < 5; j++)
//		{
//			if (array[i, j] != -1)
//			{
//				found = false;
//			}
//		}
//		if (found)
//		{
//			return true;
//		}
//	}

//	// Vertically
//	for (int i = 0; i < 5; i++)
//	{
//		bool found = true;
//		for (int j = 0; j < 5; j++)
//		{
//			if (array[j, i] != -1)
//			{
//				found = false;
//			}
//		}
//		if (found)
//		{
//			return true;
//		}
//	}

//	return false;
//}

#endregion Day4

#region Day5

//string[] text = File.ReadAllLines(@"C:\Users\mbaker\Documents\AoC\2021\Day 5\input.txt");

//int[,] map = new int[1000, 1000];
//List<int> values = new List<int>();

//for (int i = 0; i < text.Length; i++)
//{
//	string[] temp = text[i].Split(' ');

//	int x1 = int.Parse(temp[0].Split(',')[0]);
//	int y1 = int.Parse(temp[0].Split(',')[1]);
//	int x2 = int.Parse(temp[2].Split(',')[0]);
//	int y2 = int.Parse(temp[2].Split(',')[1]);

//	if (x1 == x2)
//	{
//		if (y1 > y2)
//		{
//			for (int j = y2; j<=y1; j++)
//			{
//				map[x1, j]++;
//			}
//		}
//		else
//		{
//			for (int j = y1; j <= y2; j++)
//			{
//				map[x1, j]++;
//			}
//		}
//	}
//	else if (y1 == y2)
//	{
//		if (x1 > x2)
//		{
//			for (int j = x2; j <= x1; j++)
//			{
//				map[j, y1]++;
//			}
//		}
//		else
//		{
//			for (int j = x1; j <= x2; j++)
//			{
//				map[j, y1]++;
//			}
//		}
//	}
//	else
//	{
//		if (x1 > x2 && y1 > y2)
//		{
//			for (int j = x1; j >= x2; j--)
//			{
//				map[j, y1]++;
//				y1--;
//			}
//		}
//		else if (x1 < x2 && y1 > y2)
//		{
//			for (int j = x1; j <= x2; j++)
//			{
//				map[j, y1]++;
//				y1--;
//			}
//		}
//		else if (x1 > x2 && y1 < y2)
//		{
//			for (int j = x1; j >= x2; j--)
//			{
//				map[j, y1]++;
//				y1++;
//			}
//		}
//		else
//		{
//			for (int j = x1; j <= x2; j++)
//			{
//				map[j, y1]++;
//				y1++;
//			}
//		}


//	}
//}

//int count = 0;
//foreach (int a in map)
//{
//	if (a >= 2)
//	{
//		count++;
//	}
//}


//Console.WriteLine(count);
//Console.ReadLine();
#endregion Day5

#region Day6
//string[] text = File.ReadAllLines(@"C:\Users\mbaker\Documents\AoC\2021\Day 6\input.txt");
//string[] fish = text[0].Split(',');
//List<int> ages = new List<int>();
//long[] betterArray = new long[10];

//foreach (string fishy in fish)
//{
//	ages.Add(int.Parse(fishy));
//} 

//for (int i = 0; i < 10; i++)
//{
//	betterArray[i] = getCount(i, ages);
//}


//for (int i = 0; i < 256; i++)
//{
//	long[] tempArray = new long[10];
//	foreach (long better in betterArray)
//	{
//		Console.Write(better + " ");
//	}
//	Console.WriteLine();
//	for (int j = 9; j >= 0; j--)
//	{
//		if (j == 0)
//		{
//			tempArray[6] += betterArray[0];
//			tempArray[8] += betterArray[0];
//		}
//		else
//		{
//			tempArray[j-1] += betterArray[j];
//		}

//	}
//	betterArray = tempArray;
//}


//long total = 0;
//foreach (long num in betterArray)
//{
//	total += num;
//}

//Console.WriteLine(total);
//Console.ReadLine();


//int getCount(int x, List<int> ints)
//{
//	int count = 0;
//	foreach (int y in ints)
//	{
//		if (y == x)
//		{
//			count++;
//		}
//	}
//	return count;
//}

#endregion Day6

#region Day7

//string[] text = File.ReadAllLines(@"C:\Users\mbaker\Documents\AoC\2021\Day 7\input.txt");

//string[] crabs = text[0].Split(',');
//List<int> positions = new List<int>();

//foreach (string crab in crabs)
//{
//	positions.Add(int.Parse(crab));
//}

//int[] costs = new int[positions.Max()];

//for (int i = 0; i < positions.Max(); i++)
//{
//	int fuel = 0;
//	foreach (int position in positions)
//	{
//		int n = Math.Abs(position - i);
//		fuel += (n*(n+1))/2;
//	}
//	costs[i] = fuel;
//}

//int least = int.MaxValue;
//foreach (int cost in costs)
//{
//	if (cost < least)
//	{
//		least = cost;
//	}
//}


//Console.WriteLine(least);
//Console.ReadLine();


#endregion Day7

#region Day8
// Part 1
//string[] text = File.ReadAllLines(@"C:\Users\mbaker\Documents\AoC\2021\Day 8\input.txt");
//int count = 0;

//foreach (string line in text)
//{
//	string[] temp = line.Split('|');
//	string[] temp2 = temp[1].Split(' ');
//	foreach (string tempstring in temp2)
//	{
//		if (tempstring.Length == 2 || tempstring.Length == 3 || tempstring.Length == 4 || tempstring.Length == 7)
//		{
//			count++;
//		}
//	}
//}

//Console.WriteLine(count);
//Console.ReadLine();

#endregion Day8

#region Day9

//string[] text = File.ReadAllLines(@"C:\Users\mbaker\Documents\AoC\2021\Day 9\input.txt");

//List<string[]> list = new List<string[]>();

//foreach (string line in text)
//{
//	list.Add(line.ToCharArray().Select(c => c.ToString()).ToArray());
//}

//List<int> basins = new List<int>();

//List<int[]> map = new List<int[]>();

//for (int i = 0; i < 100; i++)
//{
//	map.Add(new int[100]);
//}

//for (int x = 0; x < list.Count; x++)
//{
//	for (int y = 0; y < list[x].Length; y++)
//	{
//		int value = int.Parse(list[x][y]);
//		if (x == 0)
//		{
//			if (y == 0)
//			{
//				if (int.Parse(list[x][y + 1]) > value &&  int.Parse(list[x + 1][y]) > value )
//				{
//					mapBasin(new int[] { x, y });
//				}
//			}
//			else if (y == list[x].Length - 1)
//			{
//				if (int.Parse(list[x][y - 1]) > value  && int.Parse(list[x + 1][y]) > value)
//				{
//					mapBasin(new int[] { x, y });
//				}
//			}
//			else
//			{
//				if (int.Parse(list[x][y - 1]) > value && int.Parse(list[x][y + 1]) > value  && int.Parse(list[x + 1][y]) > value )
//				{
//					mapBasin(new int[] { x, y });
//				}
//			}
//		}
//		else if (y == 0)
//		{
//			if (x == list.Count - 1)
//			{
//				if (int.Parse(list[x - 1][y]) > value && int.Parse(list[x][y + 1]) > value)
//				{
//					mapBasin(new int[] { x, y });
//				}
//			}
//			else
//			{
//				if (int.Parse(list[x - 1][y]) > value && int.Parse(list[x][y + 1]) > value && int.Parse(list[x + 1][y]) > value )
//				{
//					mapBasin(new int[] { x, y });
//				}
//			}
//		}
//		else if (x == list.Count - 1)
//		{
//			if (y == list[x].Length - 1)
//			{
//				if (int.Parse(list[x - 1][y]) > value && int.Parse(list[x][y - 1]) > value)
//				{
//					mapBasin(new int[] { x, y });
//				}
//			}
//			else
//			{
//				if (int.Parse(list[x - 1][y]) > value && int.Parse(list[x][y - 1]) > value && int.Parse(list[x][y + 1]) > value)
//				{
//					mapBasin(new int[] { x, y });
//				}
//			}
//		}
//		else if (y == list[x].Length - 1)
//		{
//			if (int.Parse(list[x - 1][y]) > value && int.Parse(list[x][y - 1]) > value  && int.Parse(list[x + 1][y]) > value)
//			{
//				mapBasin(new int[] { x, y });
//			}
//		}
//		else 
//		{
//			if (int.Parse(list[x - 1][y]) > value && int.Parse(list[x][y - 1]) > value && int.Parse(list[x][y + 1]) > value && int.Parse(list[x + 1][y]) > value )
//			{
//				mapBasin(new int[] { x, y });
//			}		
//		}
//	}
//}


//for (int x = 0; x < list.Count; x++)
//{
//	for (int y = 0; y < list[x].Length; y++)
//	{
//		int value = int.Parse(list[x][y]);
//		if (x == 0)
//		{
//			if (y == 0)
//			{
//				if (int.Parse(list[x][y + 1]) > value && int.Parse(list[x + 1][y]) > value)
//				{
//					basins.Add(scoreBasin(new int[] { x, y }));
//				}
//			}
//			else if (y == list[x].Length - 1)
//			{
//				if (int.Parse(list[x][y - 1]) > value && int.Parse(list[x + 1][y]) > value)
//				{
//					basins.Add(scoreBasin(new int[] { x, y }));
//				}
//			}
//			else
//			{
//				if (int.Parse(list[x][y - 1]) > value && int.Parse(list[x][y + 1]) > value && int.Parse(list[x + 1][y]) > value)
//				{
//					basins.Add(scoreBasin(new int[] { x, y }));
//				}
//			}
//		}
//		else if (y == 0)
//		{
//			if (x == list.Count - 1)
//			{
//				if (int.Parse(list[x - 1][y]) > value && int.Parse(list[x][y + 1]) > value)
//				{
//					basins.Add(scoreBasin(new int[] { x, y }));
//				}
//			}
//			else
//			{
//				if (int.Parse(list[x - 1][y]) > value && int.Parse(list[x][y + 1]) > value && int.Parse(list[x + 1][y]) > value)
//				{
//					basins.Add(scoreBasin(new int[] { x, y }));
//				}
//			}
//		}
//		else if (x == list.Count - 1)
//		{
//			if (y == list[x].Length - 1)
//			{
//				if (int.Parse(list[x - 1][y]) > value && int.Parse(list[x][y - 1]) > value)
//				{
//					basins.Add(scoreBasin(new int[] { x, y }));
//				}
//			}
//			else
//			{
//				if (int.Parse(list[x - 1][y]) > value && int.Parse(list[x][y - 1]) > value && int.Parse(list[x][y + 1]) > value)
//				{
//					basins.Add(scoreBasin(new int[] { x, y }));
//				}
//			}
//		}
//		else if (y == list[x].Length - 1)
//		{
//			if (int.Parse(list[x - 1][y]) > value && int.Parse(list[x][y - 1]) > value && int.Parse(list[x + 1][y]) > value)
//			{
//				basins.Add(scoreBasin(new int[] { x, y }));
//			}
//		}
//		else
//		{
//			if (int.Parse(list[x - 1][y]) > value && int.Parse(list[x][y - 1]) > value && int.Parse(list[x][y + 1]) > value && int.Parse(list[x + 1][y]) > value)
//			{
//				basins.Add(scoreBasin(new int[] { x, y }));
//			}
//		}
//	}
//}



//void mapBasin(int[] position)
//{
//	int x = position[0];
//	int y = position[1];
//	int value = int.Parse(list[x][y]);

//	map[x][y] = 1;

//	if (y < list[x].Length - 1 && int.Parse(list[x][y + 1]) != 9 && value < int.Parse(list[x][y + 1]))
//	{
//		mapBasin(new int[] { x, y + 1 });
//	}
//	if (y > 0 && int.Parse(list[x][y - 1]) != 9 && value < int.Parse(list[x][y - 1]))
//	{
//		mapBasin(new int[] { x, y - 1 });
//	}
//	if (x < list.Count-1 && int.Parse(list[x + 1][y]) != 9 && value < int.Parse(list[x + 1][y]))
//	{
//		mapBasin(new int[] { x + 1, y });
//	}
//	if (x > 0 && int.Parse(list[x - 1][y]) != 9 && value < int.Parse(list[x - 1][y]))
//	{
//		mapBasin(new int[] { x - 1, y });
//	}
//}


//int scoreBasin(int[] position)
//{
//	int score = 1;
//	int x = position[0];
//	int y = position[1];
//	int value = int.Parse(list[x][y]);

//	map[x][y] = 0;

//	if (y < list[x].Length - 1 && map[x][y + 1] == 1)
//	{
//		score += scoreBasin(new int[] { x, y + 1 });
//	}
//	if (y > 0 && map[x][y - 1] == 1)
//	{
//		score += scoreBasin(new int[] { x, y - 1 });
//	}
//	if (x < list.Count - 1 && map[x + 1][y] == 1)
//	{
//		score += scoreBasin(new int[] { x + 1, y });
//	}
//	if (x > 0 && map[x - 1][y] == 1)
//	{
//		score += scoreBasin(new int[] { x - 1, y });
//	}
//	return score;
//}


//int[] greatest = new int[3];

//foreach (int basin in basins)
//{
//	Console.WriteLine(basin);
//	if (basin > greatest[0])
//	{
//		greatest[0] = basin;
//	}
//	else if (basin > greatest[1])
//	{
//		greatest[1] = basin;
//	}
//	else if (basin > greatest[2])
//	{
//		greatest[2] = basin;
//	}
//}

//basins.Sort();

//greatest[0] = basins[basins.Count - 1];
//greatest[1] = basins[basins.Count - 2];
//greatest[2] = basins[basins.Count - 3];

//Console.WriteLine();
//Console.WriteLine(greatest[0]);
//Console.WriteLine(greatest[1]);
//Console.WriteLine(greatest[2]);

//foreach (int[] a in map)
//{
//	foreach (int b in a)
//	{
//		Console.Write(b);
//	}
//	Console.WriteLine();
//}

//Console.WriteLine(greatest[0]*greatest[1]*greatest[2]);
//Console.ReadLine();







// *** FOR REFERENCE ***


//int returnBasin(int[] position)
//{
//	int score = 1;
//	int x = position[0];
//	int y = position[1];
//	int value = int.Parse(list[x][y]);

//	map[x][y] = 1;

//	if (y < list[x].Length - 1 && int.Parse(list[x][y + 1]) != 9 && value < int.Parse(list[x][y + 1]))
//	{
//		score += returnBasin(new int[] { x, y + 1 });
//	}
//	if (y > 0 && int.Parse(list[x][y - 1]) != 9 && value < int.Parse(list[x][y - 1]))
//	{
//		score += returnBasin(new int[] { x, y - 1 });
//	}
//	if (x < list.Count - 1 && int.Parse(list[x + 1][y]) != 9 && value < int.Parse(list[x + 1][y]))
//	{
//		score += returnBasin(new int[] { x + 1, y });
//	}
//	if (x > 0 && int.Parse(list[x - 1][y]) != 9 && value < int.Parse(list[x - 1][y]))
//	{
//		score += returnBasin(new int[] { x - 1, y });
//	}

//	return score;
//}

















//for (int x = 0; x < list.Count; x++)
//{
//	for (int y = 0; y < list[x].Length; y++)
//	{
//		int value = int.Parse(list[x][y]);
//		if (x == 0)
//		{
//			if (y == 0)
//			{
//				if (int.Parse(list[x][y + 1]) > value && int.Parse(list[x + 1][y]) > value && int.Parse(list[x + 1][y + 1]) > value)
//				{
//					count++;
//				}
//			}
//			else if (y == list[x].Length - 1)
//			{
//				if (int.Parse(list[x][y - 1]) > value && int.Parse(list[x + 1][y - 1]) > value && int.Parse(list[x + 1][y]) > value)
//				{
//					count++;
//				}
//			}
//			else
//			{
//				if (int.Parse(list[x][y - 1]) > value && int.Parse(list[x][y + 1]) > value && int.Parse(list[x + 1][y - 1]) > value && int.Parse(list[x + 1][y]) > value && int.Parse(list[x + 1][y + 1]) > value)
//				{
//					count++;
//				}
//			}
//		}
//		else if (y == 0)
//		{
//			if (x == list.Count - 1)
//			{
//				if (int.Parse(list[x - 1][y]) > value && int.Parse(list[x - 1][y + 1]) > value && int.Parse(list[x][y + 1]) > value)
//				{
//					count++;
//				}
//			}
//			else
//			{
//				if (int.Parse(list[x - 1][y]) > value && int.Parse(list[x - 1][y + 1]) > value && int.Parse(list[x][y + 1]) > value && int.Parse(list[x + 1][y]) > value && int.Parse(list[x + 1][y + 1]) > value)
//				{
//					count++;
//				}
//			}
//		}
//		else if (x == list.Count - 1)
//		{
//			if (y == list[x].Length - 1)
//			{
//				if (int.Parse(list[x - 1][y - 1]) > value && int.Parse(list[x - 1][y]) > value && int.Parse(list[x][y - 1]) > value)
//				{
//					count++;
//				}
//			}
//			else
//			{
//				if (int.Parse(list[x - 1][y - 1]) > value && int.Parse(list[x - 1][y]) > value && int.Parse(list[x - 1][y + 1]) > value && int.Parse(list[x][y - 1]) > value && int.Parse(list[x][y + 1]) > value)
//				{
//					count++;
//				}
//			}
//		}
//		else if (y == list[x].Length - 1)
//		{
//			if (int.Parse(list[x - 1][y - 1]) > value && int.Parse(list[x - 1][y]) > value && int.Parse(list[x][y - 1]) > value && int.Parse(list[x + 1][y - 1]) > value && int.Parse(list[x + 1][y]) > value)
//			{
//				count++;
//			}
//		}
//		else
//		{
//			if (int.Parse(list[x - 1][y - 1]) > value && int.Parse(list[x - 1][y]) > value && int.Parse(list[x - 1][y + 1]) > value && int.Parse(list[x][y - 1]) > value && int.Parse(list[x][y + 1]) > value && int.Parse(list[x + 1][y - 1]) > value && int.Parse(list[x + 1][y]) > value && int.Parse(list[x + 1][y + 1]) > value)
//			{
//				count++;
//			}
//		}
//	}
//}

#endregion Day9

#region Day10
//string[] text = File.ReadAllLines(@"C:\Users\mbaker\Documents\AoC\2021\Day 10\input.txt");

//List<long> scores = new List<long>();

//foreach (string line in text)
//{
//	List<char> list = new List<char>();
//	char[] chars = line.ToCharArray();
//	bool corrupt = false;

//	foreach (char c in chars)
//	{
//		if (c == ')')
//		{
//			if (list[list.Count - 1] == '(')
//			{
//				list.RemoveAt(list.Count - 1);
//			}
//			else
//			{
//				corrupt = true;
//			}
//		}
//		else if (c == ']')
//		{
//			if (list[list.Count - 1] == '[')
//			{
//				list.RemoveAt(list.Count - 1);
//			}
//			else
//			{
//				corrupt = true;
//			}
//		}
//		else if (c == '}')
//		{
//			if (list[list.Count - 1] == '{')
//			{
//				list.RemoveAt(list.Count - 1);
//			}
//			else
//			{
//				corrupt = true;
//			}
//		}
//		else if (c == '>')
//		{
//			if (list[list.Count-1] == '<')
//			{
//				list.RemoveAt(list.Count - 1);
//			}
//			else
//			{
//				corrupt = true;
//			}
//		}
//		else
//		{
//			list.Add(c);
//		}
//	}


//	if (!corrupt)
//	{
//		long score = 0;
//		for (int i = list.Count - 1; i > -1; i--)
//		{
//			score *= 5;
//			if (list[i] == '(')
//			{
//				score += 1;
//			}
//			else if (list[i] == '[')
//			{
//				score += 2;
//			}
//			else if (list[i] == '{')
//			{
//				score += 3;
//			}
//			else if (list[i] == '<')
//			{
//				score += 4;
//			}
//			else
//			{
//				Console.WriteLine("ERROR");
//			}
//		}
//		scores.Add(score);
//	}

//}

//scores.Sort();

//Console.WriteLine(scores[(scores.Count-1)/2]);
//Console.ReadLine();

#endregion Day10

#region Day11
//string[] text = File.ReadAllLines(@"C:\Users\mbaker\Documents\AoC\2021\Day 11\input.txt");

//List<int[]> map = new List<int[]>();

//for (int i = 0; i < 10; i++)
//{
//	map.Add(new int[10]);
//}

//for (int i = 0; i < text.Length; i++)
//{
//	char[] chars = text[i].ToCharArray();
//	for (int j = 0; j < chars.Length; j++)
//	{
//		map[i][j] = int.Parse(chars[j].ToString());
//	}
//}

//int count = 0;

//for (int i = 0; i < 10000; i++)
//{
//	// Add 1 to each octopus
//	for (int x = 0; x < map.Count; x++)
//	{
//		for (int y = 0; y < map[x].Length; y++)
//		{
//			map[x][y] += 1;
//		}
//	}

//	bool light = true;
//	while (light)
//	{
//		light = false;
//		for (int x = 0; x < map.Count; x++)
//		{
//			for (int y = 0; y < map[x].Length; y++)
//			{
//				if (map[x][y] > 9)
//				{
//					if (x > 0 && y > 0 && map[x - 1][y - 1] != 0)
//					{
//						map[x - 1][y - 1]++;
//						light = true;
//					}
//					if (x > 0 && map[x - 1][y] != 0)
//					{
//						map[x - 1][y]++;
//						light = true;
//					}
//					if (x > 0 && y < map[x].Length - 1 && map[x - 1][y + 1] != 0)
//					{
//						map[x - 1][y + 1]++;
//						light = true;
//					}
//					if (y > 0 && map[x][y - 1] != 0)
//					{
//						map[x][y - 1]++;
//						light = true;
//					}
//					if (y < map[x].Length - 1 && map[x][y + 1] != 0)
//					{
//						map[x][y + 1]++;
//						light = true;
//					}
//					if (x < map.Count - 1 && y > 0 && map[x + 1][y - 1] != 0)
//					{
//						map[x + 1][y - 1]++;
//						light = true;
//					}
//					if (x < map.Count - 1 && map[x + 1][y] != 0)
//					{
//						map[x + 1][y]++;
//						light = true;
//					}
//					if (x < map.Count - 1 && y < map[x].Length - 1 && map[x + 1][y + 1] != 0)
//					{
//						map[x + 1][y + 1]++;
//						light = true;
//					}

//					map[x][y] = 0;
//					count++;
//				}
//			}
//		}
//	}

//	bool simul = true;

//	for (int x = 0; x < map.Count; x++)
//	{
//		for (int y = 0; y < map[x].Length; y++)
//		{
//			if (map[x][y] != 0)
//			{
//				simul = false;
//			}
//		}
//	}

//	// Part 2
//	if (simul)
//	{
//		Console.WriteLine(i+1);
//		break;
//	}
//}



//// Part 1
//Console.WriteLine(count);
//Console.ReadLine();

#endregion Day11

#region Day12

// Go through them all first and find all connections
// Then go through and calculate routes
string[] text = File.ReadAllLines(@"C:\Users\mbaker\Documents\AoC\2021\Day 12\input.txt");
List<node> nodes = new List<node>();
int paths = 0;

foreach (string line in text)
{
	string[] caves = line.Split("-");

	if (!isInList(caves[0]))
	{
		nodes.Add(new node(caves[0]));
	}
	if (!isInList(caves[1]))
	{
		nodes.Add(new node(caves[1]));
	}

	foreach (node currNode in nodes)
	{
		if (currNode.name == caves[0])
		{
			currNode.connections.Add(caves[1]);
		}
		if (currNode.name == caves[1])
		{
			currNode.connections.Add(caves[0]);
		}
	}

}

findRoutes("start", new List<string>());
Console.WriteLine(paths);
Console.ReadLine();


// Functions
bool isInList(string caveName)
{
	bool inList = false;

	foreach (node currNode in nodes)
	{
		if (currNode.name == caveName)
		{
			inList = true;
		}
	}

	return inList;
}

void findRoutes(string caveName, List<string> cavesVisited)
{
	node caveNow = null;

	if (!char.IsUpper(caveName[0]))
	{
		cavesVisited.Add(caveName);
	}

	foreach (node currNode in nodes)
	{
		if (currNode.name == caveName)
		{
			caveNow = currNode;
		}
	}

	foreach (string connect in caveNow.connections)
	{
		if (connect == "end")
		{
			paths++;
		}
		else if (!cavesVisited.Contains(connect))
		{
			findRoutes(connect, new List<string>(cavesVisited));
		}
	}
}

// Classes
class node{

	public string name;
	public List<string> connections;

	public node(string name)
	{
		this.name = name;
		connections = new List<string>();
	}
}

#endregion Day12

#region Day25
//List<string> input = new();
//using (StreamReader sr = new StreamReader(@"C:\Users\mbaker\Documents\AoC\2021\Day 25\input.txt"))
//{
//	while (!sr.EndOfStream)
//		input.Add(sr.ReadLine());
//}

//int numRows = input.Count;
//int numCols = input[0].Length;

//char[][] board = new char[numRows][];
//bool[][] canMove = new bool[numRows][];

//for (int i = 0; i < numRows; i++)
//{
//	board[i] = new char[numCols];
//	for (int j = 0; j < numCols; j++)
//	{
//		board[i][j] = input[i][j];
//	}
//	canMove[i] = new bool[numCols];
//}


//bool hasEastMove = true;
//bool hasSouthMove = true;
//int numMoves = 0;
//int fctr = 0;
//while (hasEastMove || hasSouthMove)
//{

//	hasEastMove = false;
//	hasSouthMove = false;
//	resetMove(canMove);
//	hasEastMove = calcEastMove(board, canMove);
//	writepbm(fctr, board);
//	fctr++;
//	resetMove(canMove);
//	hasSouthMove = calcSouthMove(board, canMove);
//	writepbm(fctr, board);
//	numMoves++;
//	fctr++;
//}

//Console.WriteLine(numMoves);


//static bool calcSouthMove(char[][] board, bool[][] canMove)
//{
//	int numRows = board.Length;
//	int numCols = board[0].Length;
//	bool hasSouthMove = false;

//	for (int i = 0; i < numRows; i++)
//	{
//		for (int j = 0; j < numCols; j++)
//		{
//			if (board[i][j] == 'v')
//			{
//				//need to check to the east
//				int oneSouth = ((i + 1) == numRows) ? 0 : i + 1;
//				if (board[oneSouth][j] == '.')
//				{
//					canMove[i][j] = true;
//					hasSouthMove = true;
//				}
//			}
//		}
//	}

//	for (int i = 0; i < numRows; i++)
//	{
//		for (int j = 0; j < numCols; j++)
//		{
//			if (canMove[i][j])
//			{
//				//need to move to the east
//				int oneSouth = ((i + 1) == numRows) ? 0 : i + 1;
//				board[i][j] = '.';
//				board[oneSouth][j] = 'v';
//			}
//		}
//	}

//	return hasSouthMove;
//}

//static bool calcEastMove(char[][] board, bool[][] canMove)
//{
//	int numRows = board.Length;
//	int numCols = board[0].Length;
//	bool hasEastMove = false;

//	for (int i = 0; i < numRows; i++)
//	{
//		for (int j = 0; j < numCols; j++)
//		{
//			if (board[i][j] == '>')
//			{
//				//need to check to the east
//				int oneEast = ((j + 1) == numCols) ? 0 : j + 1;
//				if (board[i][oneEast] == '.')
//				{
//					canMove[i][j] = true;
//					hasEastMove = true;
//				}
//			}
//		}
//	}

//	for (int i = 0; i < numRows; i++)
//	{
//		for (int j = 0; j < numCols; j++)
//		{
//			if (canMove[i][j])
//			{
//				//need to move to the east
//				int oneEast = ((j + 1) == numCols) ? 0 : j + 1;
//				board[i][j] = '.';
//				board[i][oneEast] = '>';
//			}
//		}
//	}

//	return hasEastMove;
//}

//static void writepbm(int filectr, char[][] board)
//{
//	int numRows = board.Length;
//	int numCols = board[0].Length;
//	string fname = "Day25_" + string.Format("{0:####}", filectr) + ".pgm";
//	Dictionary<char, string> convert = new Dictionary<char, string>();
//	convert.Add('.', "20 "); convert.Add('>', "0 "); convert.Add('v', "10 ");
//	using (StreamWriter sw = new StreamWriter(fname))
//	{
//		sw.WriteLine("P2");
//		sw.WriteLine("{0} {1}", numCols, numRows);
//		sw.WriteLine("20");
//		foreach (char[] row in board)
//		{
//			foreach (char c in row)
//			{
//				sw.Write(convert[c]);
//			}
//			sw.WriteLine();
//		}
//	}
//}

//static void resetMove(bool[][] arr)
//{
//	for (int i = 0; i < arr.Length; i++)
//	{
//		for (int j = 0; j < arr[0].Length; j++)
//		{
//			arr[i][j] = false;
//		}
//	}
//}

//Console.ReadLine();
#endregion Day25