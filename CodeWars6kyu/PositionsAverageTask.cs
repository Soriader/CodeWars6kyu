using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class PositionsAverageTask
	{
		public static double PosAverage(string s)
		{
			var substrings = s.Split(", ");
			int totalPairs = 0;
			int totalCommon = 0;

			int n = substrings.Length;

			for (int i = 0; i < n; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					totalPairs++;
					totalCommon += ComparePositions(substrings[i], substrings[j]);
				}
			}

			double average = (double)totalCommon / (totalPairs * substrings[0].Length);
			return average * 100;
		}

		private static int ComparePositions(string a, string b)
		{
			int pair = 0;
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] == b[i])
				{
					pair++;
				}
			}
			return pair;
		}
	}
}
//https://www.codewars.com/kata/59f4a0acbee84576800000af/train/csharp