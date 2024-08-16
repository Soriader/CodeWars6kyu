using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class BinaryToTextASCIIConversionTask
	{
		public static string BinaryToString(string binary)
		{
			var check = binary.ToCharArray();
			int iterator = 0;
			string result = "";
			string checkTheNumberOfBinaryCode = "";

			for (int i = 0; i < check.Length; i++)
			{
				checkTheNumberOfBinaryCode += check[i] - '0';
				iterator++;

				if(iterator == 8)
				{
					iterator = 0;
					int decimalValue = Convert.ToInt32(checkTheNumberOfBinaryCode, 2);
					char asciiChar = (char)decimalValue;
					result += asciiChar;
					checkTheNumberOfBinaryCode = "";
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/5583d268479559400d000064/train/csharp