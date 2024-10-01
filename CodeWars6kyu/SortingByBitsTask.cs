using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars6kyu
{
	public class SortingByBitsTask
	{
		public static int[] SortByBit(int[] array)
		{
			return array.OrderBy(x => Convert.ToString(x, 2).Count(c => c == '1'))
						.ThenBy(x => x)
						.ToArray();

		}
	}
}
//https://www.codewars.com/kata/59fa8e2646d8433ee200003f/train/csharp