using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class TheBookOfMormonTask
    {
		public static long Mormons(long startingNumber, long reach, long target)
		{
			long result = 0;

			while(startingNumber < target)
			{
				startingNumber += startingNumber * reach;
				result++;
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/58373ba351e3b615de0001c3/train/csharp