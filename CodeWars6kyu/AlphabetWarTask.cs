using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class AlphabetWarTask
	{
		private static Dictionary<char, int> LeftSide = new()
	{
		{ 'w', 4 },
		{ 'p', 3 },
		{ 'b', 2 },
		{ 's', 1 },
	};

		private static Dictionary<char, int> RightSide = new()
	{
		{ 'm', 4 },
		{ 'q', 3 },
		{ 'd', 2 },
		{ 'z', 1 },
	};

		public static string AlphabetWar(string fight)
		{
			List<char> battlefield = new List<char>(fight);

			for (int i = 0; i < battlefield.Count; i++)
			{
				if (battlefield[i] == '*')
				{
					if (i > 0 && battlefield[i - 1] != '*')
					{
						battlefield[i - 1] = '_'; 
					}
					if (i < battlefield.Count - 1 && battlefield[i + 1] != '*')
					{
						battlefield[i + 1] = '_'; 
					}
					battlefield[i] = '_'; 
				}
			}

			battlefield.RemoveAll(c => c == '_');

			int leftScore = 0;
			int rightScore = 0;

			foreach (char c in battlefield)
			{
				if (LeftSide.ContainsKey(c))
				{
					leftScore += LeftSide[c];
				}
				else if (RightSide.ContainsKey(c))
				{
					rightScore += RightSide[c];
				}
			}

			if (leftScore > rightScore)
			{
				return "Left side wins!";
			}
			else if (rightScore > leftScore)
			{
				return "Right side wins!";
			}
			else
			{
				return "Let's fight again!";
			}
		}
	}
}
//https://www.codewars.com/kata/5938f5b606c3033f4700015a/train/csharp