using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class GrillItTask
	{
		public static string Grille(string message, int code)
		{
			string result = "";

			var binaryCode = Convert.ToString(code, 2);

			if (binaryCode.Length > message.Length)
			{
				binaryCode = binaryCode.Substring(binaryCode.Length - message.Length);
			}
			else
			{
				binaryCode = binaryCode.PadLeft(message.Length, '0');
			}

			for (int i = 0; i < message.Length; i++)
			{

				if (binaryCode[i] == '1')
				{
					result += message[i];
				}

			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/595b3f0ad26b2d817400002a/train/csharp