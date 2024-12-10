using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class WordsToHexTask
	{
		public static string[] WordsToHex(string words)
		{
			var partOfWords = words.Split(' ');
			List<string> result = new List<string>();

			foreach (var word in partOfWords)
			{
				var wordToChange = word.PadRight(3, '\0');

				string r = ((int)wordToChange[0]).ToString("X2").ToLower();
				string g = ((int)wordToChange[1]).ToString("X2").ToLower();
				string b = ((int)wordToChange[2]).ToString("X2").ToLower();

				result.Add($"#{r}{g}{b}");
			}

			return result.ToArray();
		}
	}
}
//https://www.codewars.com/kata/596e91b48c92ceff0c00001f/train/csharp