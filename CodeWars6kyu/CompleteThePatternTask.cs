using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class CompleteThePatternTask
	{
		public static string Pattern(int n)
		{
			if (n < 1)
			{
				return "";
			}

			var result = new List<string>();
			int totalLength = 2 * n - 1; 

			for (int i = 1; i <= n; i++)
			{
				int frontBackspace = i - 1;
				int innerSpace = totalLength - 2 - 2 * frontBackspace;

				if (innerSpace > 0)
				{
					result.Add($"{new string(' ', frontBackspace)}{i % 10}{new string(' ', innerSpace)}{i % 10}{new string(' ', frontBackspace)}");
				}
				else
				{
					result.Add($"{new string(' ', frontBackspace)}{i % 10}{new string(' ', frontBackspace)}");
				}
			}

			for (int i = n - 1; i >= 1; i--)
			{
				int frontBackspace = i - 1;
				int innerSpace = totalLength - 2 - 2 * frontBackspace;

				if (innerSpace > 0)
				{
					result.Add($"{new string(' ', frontBackspace)}{i % 10}{new string(' ', innerSpace)}{i % 10}{new string(' ', frontBackspace)}");
				}
				else
				{
					result.Add($"{new string(' ', frontBackspace)}{i % 10}{new string(' ', frontBackspace)}");
				}
			}

			return string.Join("\n", result);
		}


	}
}
//https://www.codewars.com/kata/558ac25e552b51dbc60000c3/train/csharp
