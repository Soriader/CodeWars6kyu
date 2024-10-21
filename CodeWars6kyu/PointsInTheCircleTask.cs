using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class PointsInTheCircleTask
	{
		public static int PointsNumber(int radius)
		{
			int iterator = 0;

			for (int x = -radius; x <= radius; x++)
			{
				int maxY = (int)Math.Sqrt(radius * radius - x * x);
				iterator += 2 * maxY + 1;
			}

			return iterator;
		}
	}
}
//https://www.codewars.com/kata/5b55c49d4a317adff500015f/train/csharp