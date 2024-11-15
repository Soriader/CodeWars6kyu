using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class SurroundingPrimesForAValueTask
	{
		public static long[] PrimeBefAft(long num)
		{
			long befPrime = 0;
			long aftPrime = 0;

			for (long i = num - 1; i >= 2; i--)
			{
				if (IsPrime(i))
				{
					befPrime = i;
					break;
				}
			}

			for (long i = num + 1; ; i++)
			{
				if (IsPrime(i))
				{
					aftPrime = i;
					break;
				}
			}

			return new long[] { befPrime, aftPrime };
		}

		static bool IsPrime(long n)
		{
			if (n <= 1)
				return false;
			if (n == 2)
				return true;
			if (n % 2 == 0)
				return false;

			for (long i = 3; i <= Math.Sqrt(n); i += 2)
			{
				if (n % i == 0)
					return false;
			}
			return true;
		}

	}
}
//https://www.codewars.com/kata/560b8d7106ede725dd0000e2/train/csharp