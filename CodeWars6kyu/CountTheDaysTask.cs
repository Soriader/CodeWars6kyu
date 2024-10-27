using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class CountTheDaysTask
	{
		public string CountDays(DateTime d)
		{
			if (d.Date == DateTime.Now.Date)
			{
				return "Today is the day!";

			}
			else if (d <= DateTime.Today)
			{
				return "The day is in the past!";

			}
			else
			{
				TimeSpan difference = d - DateTime.Now;
				return $"{difference.Days} days";
			}
		}
	}
}
//https://www.codewars.com/kata/5837fd7d44ff282acd000157/train/csharp