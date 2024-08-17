using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class RoundByStepsTask
	{
		public static double Solution(double n)
		{
			return Math.Round(n * 2, MidpointRounding.AwayFromZero) / 2;
		}
	}
}
//https://www.codewars.com/kata/51f1342c76b586046800002a/train/csharp