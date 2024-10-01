using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class StringSubpatternRecognitionTask
	{
		public static bool HasSubpattern(string str)
		{
			int result = str.Length;

			for (int i = 1; i <= result / 2; i++)
			{
				if (result % i == 0)
				{
					string pattern = str.Substring(0, i);

					if (string.Concat(Enumerable.Repeat(pattern, result / i)) == str)
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
//https://www.codewars.com/kata/5a49f074b3bfa89b4c00002b/train/csharp