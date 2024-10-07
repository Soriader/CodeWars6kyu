using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class StringsNumbersAndCalculationTask
	{
		public static string CalculateString(string calcIt)
		{
			string numberOne = "";
			string numberTwo = "";
			var actions = "/+-*";
			string mark = "";

			foreach (char c in calcIt)
			{
				if (actions.Contains(c))
				{
					mark = c.ToString(); 
				}
				else if (char.IsDigit(c) || c == '.')
				{
					if (string.IsNullOrEmpty(mark))
					{
						numberOne += c;
					}
					else
					{
						numberTwo += c;
					}
				}
			}

			if (string.IsNullOrEmpty(numberOne) || string.IsNullOrEmpty(numberTwo))
			{
				throw new FormatException("The input string does not contain valid numbers.");
			}

			double num1 = double.Parse(numberOne, CultureInfo.InvariantCulture);
			double num2 = double.Parse(numberTwo, CultureInfo.InvariantCulture);

			double result = 0;

			switch (mark)
			{
				case "+":
					{
						result = num1 + num2;
						break;
					}

				case "-":
					{
						result = num1 - num2;
						break;
					}
				case "*":
					{
						result = num1 * num2;
						break;
					}
				case "/":
					{
						if (num2 != 0)
						{
							result = num1 / num2;
						}
						else
						{
							throw new DivideByZeroException("Cannot divide by zero.");
						}
					}

					break;
			}

			return Math.Round(result).ToString();
		}
	}
}
//https://www.codewars.com/kata/56b5dc75d362eac53d000bc8/train/csharp