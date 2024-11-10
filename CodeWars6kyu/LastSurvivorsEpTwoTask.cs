using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class LastSurvivorsEpTwoTask
    {
		public static string LastSurvivors(string str)
		{
			while (true)
			{
				var repeat = FindDuplicate(str);
				if (repeat == null) break;
				str = str.Remove(str.IndexOf(repeat.Value), 1);
				str = str.Remove(str.IndexOf(repeat.Value), 1);
				str += (char)((repeat.Value - 'a' + 1) % 26 + 'a');
			}
			return str;
		}

		private static char? FindDuplicate(string str)
		{
			var set = new HashSet<char>();
			foreach (var c in str)
			{
				if (!set.Add(c)) return c;
			}
			return null;
		}
	}
}
//https://www.codewars.com/kata/60a1aac7d5a5fc0046c89651/train/csharp