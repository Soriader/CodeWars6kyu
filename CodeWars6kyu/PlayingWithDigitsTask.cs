using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class PlayingWithDigitsTask
	{
		public static long digPow(int n, int p)
		{
			var check = n.ToString().ToCharArray();
			double numberOfExponentiationP = 0;

			for (int i = 0; i < check.Length; i++)
			{
				int digit = check[i] - '0';
				numberOfExponentiationP += Math.Pow(digit, p + i);
			}

			int k = (int)(numberOfExponentiationP / n);

			if (numberOfExponentiationP == n*k)
			{
				return k;
			}

			return -1;

		}
	}
}
//https://www.codewars.com/kata/5552101f47fc5178b1000050/train/csharp