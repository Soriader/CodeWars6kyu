using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class ClockInMirrorTask
	{
		public static string WhatIsTheTime(string timeInMirror)
		{
			var checkTheTime = timeInMirror.Split(':');
			int hour = int.Parse(checkTheTime[0]);
			int minutes = int.Parse(checkTheTime[1]);

			int realHour = 11 - hour;
			int realMinutes = 60 - minutes;

			if (realMinutes == 60)
			{
				realMinutes = 0;
				realHour += 1;
			}

			if (realHour <= 0)
			{
				realHour += 12;
			}

			return $"{realHour:D2}:{realMinutes:D2}";

		}
	}
}
//https://www.codewars.com/kata/56548dad6dae7b8756000037/train/csharp