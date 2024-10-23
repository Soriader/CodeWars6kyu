using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class ConvertIntegerToWhitespaceFormatTask
	{
		public static string WhitespaceNumber(int n)
		{
			string result = "";

			if(n > 0)
			{
				result += " ";
			}
			else if(n == 0)
			{
				return " \n";
			}
			else
			{
				result += "\t";
			}

			string binaryNumber = Convert.ToString(Math.Abs(n), 2);

			foreach (char c in binaryNumber) 
			{
				if(c == '1')
				{
					result += "\t";
				}
				else if(c == '0')
				{
					result += " ";
				}
			}


			return result + "\n"; 
		}
	}
}
//https://www.codewars.com/kata/55b350026cc02ac1a7000032/train/csharp