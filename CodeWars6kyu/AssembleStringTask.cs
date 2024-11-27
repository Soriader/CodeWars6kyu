using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class AssembleStringTask
	{
		public static string Assemble(string[] copies)
		{
			if (copies is null || copies.Length == 0)
			{
				return "";
			}

			int lengthOfWord = copies[0].Length;
			char[] mergedCopies = new char[lengthOfWord];

			for (int i = 0; i < lengthOfWord; i++)
			{
				mergedCopies[i] = '*';
			}

			foreach (var copy in copies)
			{
				int currentLength = Math.Min(copy.Length, lengthOfWord);

				for (int i = 0; i < currentLength; i++)
				{
					if (copy[i] != '*' && mergedCopies[i] == '*')
					{
						mergedCopies[i] = copy[i];
					}
				}
			}

			for (int i = 0; i < mergedCopies.Length; i++)
			{
				if (mergedCopies[i] == '*')
				{
					mergedCopies[i] = '#';
				}
			}

			return new string(mergedCopies);
		}
	}
}
//https://www.codewars.com/kata/6210fb7aabf047000f3a3ad6/train/csharp