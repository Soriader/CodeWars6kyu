using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class ReversingAndCombiningTextTask
	{
		public static string ReverseAndCombineText(string text)
		{
			var textParts = text.Split(" ").ToList();

			while (textParts.Count > 1)
			{
				var combined = new List<string>();

				for (int i = 0; i < textParts.Count; i += 2)
				{
					if (i + 1 < textParts.Count)
					{
						string combinedWord =
							new string(textParts[i].ToCharArray().Reverse().ToArray()) +
							new string(textParts[i + 1].ToCharArray().Reverse().ToArray());
						combined.Add(combinedWord);
					}
					else
					{
						combined.Add(new string(textParts[i].ToCharArray().Reverse().ToArray()));
					}
				}

				textParts = combined;
			}

			return textParts[0];
		}

	}
}
//https://www.codewars.com/kata/56b861671d36bb0aa8000819/train/csharp