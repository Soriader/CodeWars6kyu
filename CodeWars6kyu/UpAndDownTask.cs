using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class UpAndDownTask
	{
		public static string Arrange(string strng)
		{
			var words = strng.Split(" ").ToList();

			bool sorted = false;
			while (!sorted)
			{
				sorted = true; 
				for (int i = 0; i < words.Count - 1; i++)
				{
					if ((i % 2 == 0 && words[i].Length > words[i + 1].Length) || (i % 2 == 1 && words[i].Length < words[i + 1].Length))
					{
						var temp = words[i];
						words[i] = words[i + 1];
						words[i + 1] = temp;
						sorted = false;
					}
				}
			}

			for (int i = 0; i < words.Count; i++)
			{
				if (i % 2 == 0)
					words[i] = words[i].ToLower(); 
				else
					words[i] = words[i].ToUpper(); 
			}

			return string.Join(" ", words);
		}
	}
}
//https://www.codewars.com/kata/56cac350145912e68b0006f0/train/csharp