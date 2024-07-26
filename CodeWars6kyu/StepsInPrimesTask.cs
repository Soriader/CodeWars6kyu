using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class StepsInPrimesTask
	{
		public static long[] Step(int g, long m, long n)
		{
			for (long i = m; i <= n; i++)
			{
				if (isPrime(i))
				{
					if (isPrime(i + g) && (i + g) <= n)
					{
						return new long[2] { i, i + g };
					}
				}
			}
			return null;
		}

		public static bool isPrime(long number)
		{
			if (number == 1) 
			{
				return false;
			}
			if (number == 2) 
			{
				return true; 
			}

			if (number % 2 == 0) 
			{
				return false;
			}  

			for (int i = 3; i <= Math.Ceiling(Math.Sqrt(number)); i += 2)
			{
				if (number % i == 0) 
				{ 
					return false;
				} 
			}
			return true;
		}
	}
}
//https://www.codewars.com/kata/5613d06cee1e7da6d5000055/train/csharp