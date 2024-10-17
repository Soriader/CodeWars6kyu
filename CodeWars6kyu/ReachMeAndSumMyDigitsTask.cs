using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class ReachMeAndSumMyDigitsTask
	{
		public static long SumDigNthTerm(long initval, long[] patternl, int nthterm)
		{
			long value = initval;

			for (int i = 1; i < nthterm; i++)
			{
				value += patternl[(i - 1) % patternl.Length];
			}

			long sum = 0;
			foreach (char digit in value.ToString())
			{
				sum += digit - '0';
			}

			return sum;
		}
	}
}
//https://www.codewars.com/kata/55ffb44050558fdb200000a4/train/csharp