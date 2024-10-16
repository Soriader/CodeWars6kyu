using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class StringTopsTask
	{
		public static string Tops(string msg)
		{
			int index = 1;
			string result = "";

			for (int i = 2; index <= msg.Length; i++)
			{
				if (i % 2 == 0)
				{
					result = msg[index] + result;
				}

				index += i;
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/59b7571bbf10a48c75000070/train/csharp