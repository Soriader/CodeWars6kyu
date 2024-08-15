using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class PlayingOnAChessboardTask
	{
		public static string Game(long n)
		{
			if (n == 0)
			{
				return "[0]";
			}

			long numerator = n * n;
			long denominator = 2;

			if (numerator % 2 == 0)
			{
				return $"[{numerator / 2}]";
			}
			else
			{
				return $"[{numerator}, {denominator}]";
			}
		}
	}
}
//https://www.codewars.com/kata/55ab4f980f2d576c070000f4/train/csharp