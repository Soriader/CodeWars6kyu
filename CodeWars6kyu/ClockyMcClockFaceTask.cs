using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class ClockyMcClockFaceTask
	{
		public static string WhatTimeIsIt(double angle)
		{
			int hour = (int)(angle / 30);

			int minutes = (int)((angle % 30) * 2);

			if (hour == 0)
			{
				hour = 12;
			}

			return $"{hour:D2}:{minutes:D2}";
		}
	}
}
//https://www.codewars.com/kata/59752e1f064d1261cb0000ec/train/csharp