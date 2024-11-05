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
		public static Dictionary<string, string> letters = new Dictionary<string, string>(){
			{ "aa", "b" },
			{ "bb", "c" },
			{ "cc", "d" },
			{ "dd", "e" },
			{ "ee", "f" },
			{ "ff", "g" },
			{ "gg", "h" },
			{ "hh", "i" },
			{ "ii", "j" },
			{ "jj", "k" },
			{ "kk", "l" },
			{ "ll", "m" },
			{ "mm", "n" },
			{ "nn", "o" },
			{ "oo", "p" },
			{ "pp", "q" },
			{ "qq", "r" },
			{ "rr", "s" },
			{ "ss", "t" },
			{ "tt", "u" },
			{ "uu", "v" },
			{ "vv", "w" },
			{ "ww", "x" },
			{ "xx", "y" },
			{ "yy", "z" },
			{ "zz", "a" }
        };
		public static string LastSurvivors(string str)
		{
			string result = "";
			var check = str.OrderBy(x => x).ToList();
			string actualResult = "";
			bool theSame = true;

			while (theSame) 
			{
				actualResult = "";

				for (int i = 0; i < check.Count - 1; i++)
				{
					if (check[i] == check[i + 1])
					{
						string twoLetter = $"{check[i]}{check[i + 1]}";

						if (letters.ContainsKey(twoLetter))
						{
							actualResult += letters[twoLetter];
							check.RemoveAt(i + 1);
						}
					}
					else
					{
						actualResult += check[i];
					}

				}

				if(actualResult == result)
				{
					theSame = false;
				}

				result = actualResult;
			}

			return result;

		}
	}
}
//https://www.codewars.com/kata/60a1aac7d5a5fc0046c89651/train/csharp