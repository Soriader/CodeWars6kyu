using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class TheDeafRatsOfHamelinTask
	{
		public static int CountDeafRats(string town)
		{
			town = town.Replace(" ", "");

			int pIndex = town.IndexOf('P');

			int deafRatCount = 0;

			for (int i = 0; i < pIndex; i += 2)
			{
				string rat = town.Substring(i, 2);
				if (rat == "O~")
				{
					deafRatCount++;
				}
			}

			for (int i = pIndex + 1; i < town.Length; i += 2)
			{
				string rat = town.Substring(i, 2);
				if (rat == "~O") 
				{
					deafRatCount++;
				}
			}

			return deafRatCount;

		}
	}
}
//https://www.codewars.com/kata/598106cb34e205e074000031/train/csharp