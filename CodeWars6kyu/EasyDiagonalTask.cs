using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class EasyDiagonalTask
	{
		public static BigInteger Diagonal(int n, int p)
		{
			return BinomialCoefficient(n + 1, p + 1);

		}

		private static BigInteger BinomialCoefficient(int n, int k)
		{
			if (k > n) return 0;

			if (k > n - k)
			{
				k = n - k;
			}

			BigInteger result = 1;

			for (int i = 0; i < k; i++)
			{
				result *= n - i;
				result /= i + 1;
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/559b8e46fa060b2c6a0000bf/train/csharp