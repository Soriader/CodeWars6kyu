using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class TransformToPrimeTask
	{
		public static int MinimumNumber(int[] numbers)
		{
			var sumOfNumbers = numbers.Sum();
			int numberToAdded = 1;
			var check = sumOfNumbers;

			if (ToPrime(sumOfNumbers))
			{
				return 0;
			}
			else
			{
				while (!ToPrime(check))
				{
					check += numberToAdded;

					if (!ToPrime(check))
					{
						numberToAdded++;
						check = sumOfNumbers;
					}
				}
			}

			return numberToAdded;
		}

		static bool ToPrime(int n)
		{
			if (n <= 1)
			{
				return false;
			}

			if (n == 2)
			{
				return true;
			}

			if (n % 2 == 0)
			{
				return false;
			}

			for (int i = 3; i <= Math.Sqrt(n); i += 2)
			{
				if (n % i == 0)
				{
					return false;
				}
			}

			return true;
		}
	}
}
//https://www.codewars.com/kata/5a946d9fba1bb5135100007c/train/csharp