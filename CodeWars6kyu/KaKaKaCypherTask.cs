using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class KaKaKaCypherTask
	{
		public static string KaCokadekaMe(string word)
		{
			var kaActivate = "aeiouAEIOU";
			string result = "ka";

			for (int i = 0; i < word.ToCharArray().Length; i++)
			{
				if (kaActivate.Contains(word[i]) && (i != word.Length - 1 && !kaActivate.Contains(word[i + 1])))
				{
					result += $"{word[i]}ka";
				}
				else
				{
					result += word[i];
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/5934d648d95386bc8200010b/train/csharp