using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars6kyu
{
	public class WorldBitsWarTask
	{
		public static string BitsWar(List<int> numbers)
		{
			int sumOfEven = 0;
			int sumOfOdds = 0;

			foreach (int number in numbers)
			{
				string binary = Convert.ToString(Math.Abs(number), 2); 
				int bitCount = binary.Count(c => c == '1');

				int strength = number < 0 ? -bitCount : bitCount;

				if (number % 2 == 0) 
				{
					sumOfEven += strength;
				}
				else
				{
					sumOfOdds += strength;
				}
			}

			if (sumOfEven == sumOfOdds)
			{
				return "tie";
			}
			else if (sumOfEven > sumOfOdds)
			{
				return "evens win";
			}
			else
			{
				return "odds win";
			}
		}
	}
}
//https://www.codewars.com/kata/58865bfb41e04464240000b0/train/csharp