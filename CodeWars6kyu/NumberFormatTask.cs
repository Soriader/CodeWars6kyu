using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars6kyu
{
	public class NumberFormatTask
	{
		public static string NumberFormat(int number)
		{
			string result = "";
			int iterator = 0;
			string absNumberString = Math.Abs(number).ToString();

			for (int i = absNumberString.Length - 1; i >= 0; i--)
			{
				if (iterator == 3)
				{
					result += ",";
					iterator = 0;
				}

				result += absNumberString[i];
				iterator++;
				

			}

			result = new string(result.ToString().Reverse().ToArray());

			if (number < 0)
			{
				return "-" + result;

			}

			return result;


		}
	}
}
//https://www.codewars.com/kata/565c4e1303a0a006d7000127/train/csharp