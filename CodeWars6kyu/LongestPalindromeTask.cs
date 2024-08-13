using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class LongestPalindromeTask
	{
		public static int GetLongestPalindrome(string str)
		{
			if (string.IsNullOrEmpty(str))
			{
				return 0;
			}

			int maxLength = 1; 
			int length = str.Length;

			for (int i = 0; i < length; i++)
			{
				int oddLength = ExpandAroundCenter(str, i, i);
				maxLength = Math.Max(maxLength, oddLength);

				if (i + 1 < length)
				{
					int evenLength = ExpandAroundCenter(str, i, i + 1);
					maxLength = Math.Max(maxLength, evenLength);
				}
			}

			return maxLength;
		}

		private static int ExpandAroundCenter(string str, int left, int right)
		{
			while (left >= 0 && right < str.Length && str[left] == str[right])
			{
				left--;
				right++;
			}

			return right - left - 1;
		}
	}
}
//https://www.codewars.com/kata/54bb6f887e5a80180900046b/train/csharp