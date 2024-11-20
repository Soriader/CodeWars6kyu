using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class HowMuchHexIsTask
	{
		public static int FisHex(string name)
		{
			string sixteenLettersToCheck = "abcdefABCDEF";
			int result = 0;

			foreach (char c in name)
			{
				if (sixteenLettersToCheck.Contains(c))
				{
					int value = Convert.ToInt32(c.ToString(), 16);
					result ^= value;
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/5714eb80e1bf814e53000c06/train/csharp