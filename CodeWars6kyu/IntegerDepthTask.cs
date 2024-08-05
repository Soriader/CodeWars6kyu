using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class IntegerDepthTask
	{
		public static int ComputeDepth(int n)
		{
			int iterator = 1;
			int actualResult = 0;

			List<int> boxOfNumbers = new List<int>();

			while (boxOfNumbers.Count != 10)
			{
				actualResult = n * iterator;
				iterator++;

				var checkNumbers = actualResult.ToString().ToCharArray();

				for (int i = 0; i < checkNumbers.Length; i++)
				{
					int digit = checkNumbers[i] - '0';
					if (!boxOfNumbers.Contains(digit))
					{
						boxOfNumbers.Add(digit);
					}
				}
			}

			return iterator - 1;
		}
	}
}
//https://www.codewars.com/kata/59b401e24f98a813f9000026/train/csharp