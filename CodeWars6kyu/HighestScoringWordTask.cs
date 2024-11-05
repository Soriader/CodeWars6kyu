using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class HighestScoringWordTask
	{
		public static string High(string s)
		{
			Dictionary<char, int> alphabet = new Dictionary<char, int>();

			for (char letter = 'a'; letter <= 'z'; letter++)
			{
				alphabet[letter] = letter - 'a' + 1;
			}

			int highScore = 0;
			int wordScore = 0;
			string result = "";

			var check = s.Split(' ');

			foreach (var letter in check) 
			{
				wordScore = 0;

				for (int i = 0; i < letter.ToCharArray().Length; i++) 
				{
					if (alphabet.ContainsKey(letter[i]))
					{
						wordScore += alphabet[letter[i]];
					}
				}

				if (wordScore > highScore)
				{
					highScore = wordScore;
					result = letter.ToString();
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/57eb8fcdf670e99d9b000272/train/csharp