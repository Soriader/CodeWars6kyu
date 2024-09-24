using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class ColorChoiceTask
	{
		public static long Checkchoose(long m, int n)
		{
			for (int x = 0; x <= n; x++)
			{
				if (BinomialCoefficient(n, x) == m)
				{
					return x;
				}
			}
			return -1;
		}

		public static long BinomialCoefficient(int n, int x)
		{
			long result = 1;
			for (int i = 1; i <= x; i++)
			{
				result = result * (n - (x - i)) / i;
			}
			return result;
		}
	}
}
//https://www.codewars.com/kata/55be10de92aad5ef28000023/train/csharp