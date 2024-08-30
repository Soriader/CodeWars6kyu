using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class ReducingByStepsTask
	{
		public static long gcdi(long x, long y)
		{
			if (y == 0)
			{
				return Math.Abs(x);
			}
			else
			{
				return gcdi(y, x % y);
			}
		}

		public static long lcmu(long a, long b)
		{
			return Math.Abs(a * b) / gcdi(a, b);
		}

		public static long som(long a, long b)
		{
			return a + b;
		}

		public static long maxi(long a, long b)
		{
			return Math.Max(a, b);
		}

		public static long mini(long a, long b)
		{
			return Math.Min(a, b);
		}

		public static long oper(Func<long, long, long> fct, long a, long b)
		{
			return fct(a, b);
		}

		public static long[] OperArray(Func<long, long, long> fct, long[] arr, long init)
		{
			long[] result = new long[arr.Length];
			long current = init;

			for (int i = 0; i < arr.Length; i++)
			{
				current = oper(fct, current, arr[i]);
				result[i] = current;
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/56efab15740d301ab40002ee/train/csharp