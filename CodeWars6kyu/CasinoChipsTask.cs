using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class CasinoChipsTask
	{
		public static int Solve(int[] arr)
		{
			Array.Sort(arr);
			int result = 0;

			while (arr[1] > 0 && arr[2] > 0)
			{
				arr[1]--;
				arr[2]--;
				result++;
				Array.Sort(arr);
			}

			return result;
		}

	}
}
//https://www.codewars.com/kata/5e0b72d2d772160011133654/train/csharp