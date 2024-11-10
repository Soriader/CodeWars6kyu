using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class NumberPyramidTask
	{
		public static string Pattern(int n)
		{
			if (n <= 0)
			{
				return "";
			}

			var result = new List<string>();
			int maxLength = 2 * n - 1;

			for (int i = 1; i <= n; i++)
			{
				string leftPart = string.Concat(Enumerable.Range(1, i).Select(x => (x % 10).ToString()));
				string rightPart = new string(leftPart.Reverse().ToArray()).Substring(1);
				string line = leftPart + rightPart;

				int spaces = (maxLength - line.Length) / 2;
				line = line.PadLeft(line.Length + spaces).PadRight(maxLength);

				result.Add(line);
			}

			return string.Join("\n", result);
		}


	}
}
//https://www.codewars.com/kata/5575ff8c4d9c98bc96000042/train/csharp