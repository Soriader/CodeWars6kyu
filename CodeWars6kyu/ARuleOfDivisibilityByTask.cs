using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class ARuleOfDivisibilityByTask
	{
		public static long Thirt(long n)
		{
			List<int> keyNumber = new List<int> { 1, 10, 9, 12, 3, 4 };
			long oldNumber = n;
			long newNumber;

			while (true)
			{
				newNumber = 0;
				int iterator = 0;

				string replaceNumber = new string(oldNumber.ToString().Reverse().ToArray());

				for (int i = 0; i < replaceNumber.Length; i++)
				{
					newNumber += (replaceNumber[i] - '0') * keyNumber[iterator];
					iterator++;

					if (iterator >= keyNumber.Count)
					{
						iterator = 0;
					}
				}

				if (newNumber == oldNumber)
				{
					break;
				}

				oldNumber = newNumber;
			}

			return newNumber;
		}

	}
}
//https://www.codewars.com/kata/564057bc348c7200bd0000ff/train/csharp