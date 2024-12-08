using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class SimpleDivisionTask
	{
		public static bool Solve(int a, int b)
		{
			List<int> primeFactorsB = GetPrime(b);

			foreach (int prime in primeFactorsB)
			{
				if (a % prime != 0)
				{
					return false;
				}
			}

			return true;
		}

		private static List<int> GetPrime(int n)
		{
			List<int> primeFactors = new List<int>();
			int divisor = 2;

			while (n > 1)
			{
				if (n % divisor == 0)
				{
					primeFactors.Add(divisor);
					n /= divisor; 
				}
				else
				{
					divisor++;
				}
			}

			return primeFactors;
		}

	}
}
//https://www.codewars.com/kata/59ec2d112332430ce9000005/train/csharp