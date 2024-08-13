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
			double oneDegree = 0.3;

			if(0 == angle || angle >= 360)
			{
				return "12:00";
			}

			var check = angle / oneDegree;

			var toChar = check.ToString().ToCharArray();

			if(toChar.Length == 3)
			{
				return $"0{toChar[0]}:{toChar[1]}{toChar[2]}";
			}
			else
			{
				return $"{toChar[0]}{toChar[1]}:{toChar[2]}{toChar[3]}";
			}

		}
	}
}
