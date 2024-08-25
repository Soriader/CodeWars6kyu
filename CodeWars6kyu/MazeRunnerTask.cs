using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class MazeRunnerTask
	{
		public string MazeRunner(int[,] maze, string[] directions)
		{
			int startX = 0, startY = 0;
			bool foundStart = false;
			for (int i = 0; i < maze.GetLength(0); i++)
			{
				for (int j = 0; j < maze.GetLength(1); j++)
				{
					if (maze[i, j] == 2)
					{
						startX = i;
						startY = j;
						foundStart = true;
						break;
					}
				}
				if (foundStart) break;
			}

			int x = startX, y = startY;

			foreach (var direction in directions)
			{
				switch (direction)
				{
					case "N":
						x -= 1;
						break;
					case "E":
						y += 1;
						break;
					case "S":
						x += 1;
						break;
					case "W":
						y -= 1;
						break;
				}

				if (x < 0 || x >= maze.GetLength(0) || y < 0 || y >= maze.GetLength(1))
				{
					return "Dead";
				}

				if (maze[x, y] == 1)
				{
					return "Dead";
				}

				if (maze[x, y] == 3)
				{
					return "Finish";
				}
			}

			return "Lost";

		}
	}
}
//https://www.codewars.com/kata/58663693b359c4a6560001d6/train/csharp