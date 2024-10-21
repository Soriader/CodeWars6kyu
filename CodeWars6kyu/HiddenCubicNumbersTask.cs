using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class HiddenCubicNumbersTask
	{
		public static string IsSumOfCubes(string s)
		{
			List<string> numbersForCheck = new List<string>();
			string boxForNumbers = "";

			var check = s.ToCharArray();

			for (int i = 0; i < check.Length; i++)
			{
				if (char.IsDigit(check[i]))
				{
					boxForNumbers += check[i];

					if (boxForNumbers.Length == 3)
					{
						numbersForCheck.Add(boxForNumbers);
						boxForNumbers = "";
					}
				}
				else if (boxForNumbers.Length > 0)
				{
					numbersForCheck.Add(boxForNumbers);
					boxForNumbers = "";
				}
			}

			if (boxForNumbers.Length > 0)
			{
				numbersForCheck.Add(boxForNumbers);
			}

			List<int> cubicNumbers = new List<int>();

			foreach (var item in numbersForCheck)
			{
				int number = int.Parse(item);
				if (IsCubic(number))
				{
					cubicNumbers.Add(number);
				}
			}

			if (cubicNumbers.Count > 0)
			{
				int sum = cubicNumbers.Sum();
				string result = string.Join(" ", cubicNumbers) + $" {sum} Lucky";
				return result;
			}
			else
			{
				return "Unlucky";
			}
		}

		private static bool IsCubic(int number)
		{
			int sumOfCubes = number.ToString()
								   .Select(c => (int)Math.Pow(c - '0', 3))
								   .Sum();
			return sumOfCubes == number;
		}
	}
}
//https://www.codewars.com/kata/55031bba8cba40ada90011c4/train/csharp