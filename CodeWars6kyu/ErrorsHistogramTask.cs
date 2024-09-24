using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class ErrorsHistogramTask
    {
		public static string Hist(string s)
		{
			string result = "";
			var errorLetters = "uwxz";
			Dictionary<char, int> countOfErrors = new Dictionary<char, int>();

			foreach (char c in s)
			{
				if (errorLetters.Contains(c))
				{
					if (countOfErrors.ContainsKey(c))
					{
						countOfErrors[c]++;
					}
					else
					{
						countOfErrors.Add(c, 1);
					}
				}
			}

			foreach (var error in countOfErrors.OrderBy(e => e.Key))
			{
				string stars = new string('*', error.Value);
				result += $"{error.Key}  {error.Value,-6}{stars}\r"; 
			}

			return result.TrimEnd('\r');
		}

	}
}
//https://www.codewars.com/kata/59f44c7bd4b36946fd000052/train/csharp