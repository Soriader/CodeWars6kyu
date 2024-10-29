using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class TwinPrimeTask
	{
		public static bool IsTwinPrime(int n)
		{
			if (!IsPrime(n))
			{
				return false;
			}

			return IsPrime(n - 2) || IsPrime(n + 2);
		}

		private static bool IsPrime(int num)
		{
			if (num < 2)
			{
				return false;
			}
			for (int i = 2; i * i <= num; i++)
			{
				if (num % i == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}
//https://www.codewars.com/kata/59b7ae14bf10a402d40000f3/train/csharp