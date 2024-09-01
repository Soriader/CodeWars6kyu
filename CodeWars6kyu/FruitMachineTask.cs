using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class FruitMachineTask
	{
		private Dictionary<string, int> Scoring = new()
	{
		{ "Wild", 10 },
		{ "Star", 9 },
		{ "Bell", 8 },
		{ "Shell", 7 },
		{ "Seven", 6 },
		{ "Cherry", 5 },
		{ "Bar", 4 },
		{ "King", 3 },
		{ "Queen", 2 },
		{ "Jack", 1 }
	};

		public int Fruit(List<string[]> reels, int[] spins)
		{
			List<string> rolls = new();

			for (int i = 0; i < 3; i++)
			{
				string[] reel = reels[i];

				rolls.Add(reel[spins[i]]);
			}

			int score = 0;
			int wildCards = rolls.Count(x => x == "Wild");

			foreach (var kvp in Scoring)
			{
				if (rolls.Contains(kvp.Key))
				{
					int count = rolls.Count(x => x == kvp.Key);

					if (count == 2)
					{
						if (wildCards == 1)
						{
							score += kvp.Value * 2;
						}
						else
						{
							score += kvp.Value;
						}
					}
					else if (count == 3)
					{
						score += kvp.Value * 10;
					}
				}
			}

			return score;
		}
	}
}
//https://www.codewars.com/kata/590adadea658017d90000039/train/csharp