using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class SumOfPrimeIndexedElementsTask
	{
		public static int Solve(int[] arr)
		{
			int sum = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				if (IsPrime(i))
				{
					sum += arr[i];
				}
			}

			return sum;
		}

		private static bool IsPrime(int number)
		{
			if (number < 2) 
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

			for (int i = 3; i <= Math.Sqrt(number); i += 2)
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
//https://www.codewars.com/kata/59f38b033640ce9fc700015b/train/csharp