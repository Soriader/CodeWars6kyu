using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class RoboScriptTask
	{
		public static string Highlight(string code)
		{
			var result = new StringBuilder();

			var pattern = @"F+|L+|R+|\d+|\(|\)";
			var matches = Regex.Matches(code, pattern);

			foreach (Match match in matches)
			{
				string value = match.Value;
				char firstChar = value[0];

				switch (firstChar)
				{
					case 'F':
						result.Append($"<span style=\"color: pink\">{value}</span>");
						break;
					case 'L':
						result.Append($"<span style=\"color: red\">{value}</span>");
						break;
					case 'R':
						result.Append($"<span style=\"color: green\">{value}</span>");
						break;
					case char c when char.IsDigit(c):
						result.Append($"<span style=\"color: orange\">{value}</span>");
						break;
					default:
						result.Append(value);
						break;
				}
			}

			return result.ToString();

		}
	}
}
//https://www.codewars.com/kata/58708934a44cfccca60000c4/train/csharp