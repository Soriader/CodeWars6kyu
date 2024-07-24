using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class TitleCaseTask
	{
		public static string TitleCase(string title, string minorWords = "")
		{
			if (string.IsNullOrEmpty(title))
			{
				return title;
			}

			string[] minorWordsArray = string.IsNullOrEmpty(minorWords) ? new string[0] : minorWords.ToLower().Split(' ');

			string[] words = title.ToLower().Split(' ');

			for (int i = 0; i < words.Length; i++)
			{
				if (i == 0 || !minorWordsArray.Contains(words[i]))
				{
					words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
				}
			}

			return string.Join(" ", words);
		}
	}
}
//https://www.codewars.com/kata/5202ef17a402dd033c000009/train/csharp