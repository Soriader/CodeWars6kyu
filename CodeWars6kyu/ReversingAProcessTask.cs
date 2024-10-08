using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class ReversingAProcessTask
	{
		public static string Decode(string r)
		{
			string numbers = "";
			string letters = "";

			foreach (char c in r)
			{
				if (char.IsDigit(c))
				{
					numbers += c;
				}
				else
				{
					letters += c;
				}
			}

			if (string.IsNullOrEmpty(numbers))
			{
				return "Impossible to decode";
			}

			int num = int.Parse(numbers);
			string result = "";

			foreach (char ch in letters)
			{
				int encodedValue = ch - 'a';

				int inverseNum = ModInverse(num, 26);

				if (inverseNum == -1)
				{
					return "Impossible to decode"; 
				}

				int originalValue = (encodedValue * inverseNum) % 26;

				if (originalValue < 0)
				{
					originalValue += 26;
				}

				result += (char)(originalValue + 'a');
			}

			return result;
		}

		private static int ModInverse(int a, int m)
		{
			a = a % m;
			for (int x = 1; x < m; x++)
			{
				if ((a * x) % m == 1)
				{
					return x;
				}
			}
			return -1;
		}

	}
}
//https://www.codewars.com/kata/5dad6e5264e25a001918a1fc/train/csharp