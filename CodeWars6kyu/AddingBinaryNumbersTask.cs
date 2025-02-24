using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class AddingBinaryNumbersTask
	{
		//In this task I can't use Convert method
		public static string Add(string a, string b)
		{
			var resultInInt = ConvertToInt32(a) + ConvertToInt32(b);

			string binary = "";

			if (resultInInt == 0)
			{
				binary = "0";
			}
			else
			{
				while (resultInInt > 0)
				{
					binary = (resultInInt % 2) + binary; 
					resultInInt /= 2;
				}
			}

			return binary;

		}

		private static int ConvertToInt32(string s) 
		{
			int result = 0;
			for (int i = 0; i < s.Length; i++)
			{
				result = (result << 1) + (s[i] - '0');
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/55c11989e13716e35f000013/train/csharp