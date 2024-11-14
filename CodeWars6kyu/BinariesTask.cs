using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class BinariesTask
	{
		public static string Code(string strng)
		{
			Dictionary<char, string> digitToBinary = new Dictionary<char, string>
		{
			{ '0', "10" },
			{ '1', "11" },
			{ '2', "0110" },
			{ '3', "0111" },
			{ '4', "001100" },
			{ '5', "001101" },
			{ '6', "001110" },
			{ '7', "001111" },
			{ '8', "00011000" },
			{ '9', "00011001" }
		};

			string binaryCode = "";

			foreach (char digit in strng)
			{
				if (digitToBinary.ContainsKey(digit))
				{
					binaryCode += digitToBinary[digit];
				}
			}

			return binaryCode;
		}

		public static string Decode(string encodedInput)
		{
			Dictionary<string, char> binaryToDigit = new Dictionary<string, char>
		{
			{ "10", '0' },
			{ "11", '1' },
			{ "0110", '2' },
			{ "0111", '3' },
			{ "001100", '4' },
			{ "001101", '5' },
			{ "001110", '6' },
			{ "001111", '7' },
			{ "00011000", '8' },
			{ "00011001", '9' }
		};

			string result = "";
			int i = 0;

			while (i < encodedInput.Length)
			{
				foreach (var kvp in binaryToDigit)
				{
					string binaryCode = kvp.Key;
					char digit = kvp.Value;

					if (encodedInput.Substring(i).StartsWith(binaryCode))
					{
						result += digit;
						i += binaryCode.Length;
						break;
					}
				}
			}

			return result;
		}
	}

}
//https://www.codewars.com/kata/5d98b6b38b0f6c001a461198/train/csharp