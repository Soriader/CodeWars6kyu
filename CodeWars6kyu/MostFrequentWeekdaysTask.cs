using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class MostFrequentWeekdaysTask
	{
		public static string[] MostFrequentDays(int year)
		{
			Dictionary<string, int> days = new Dictionary<string, int>()
			{
				{ "Monday", 0 },
				{ "Tuesday", 0 },
				{ "Wednesday", 0 },
				{ "Thursday", 0 },
				{ "Friday", 0 },
				{ "Saturday", 0 },
				{ "Sunday", 0 }
			};

			DateTime dateTime = new DateTime(year, 1, 1);

			int daysInYear = DateTime.IsLeapYear(year) ? 366 : 365;

			for (int i = 0; i < daysInYear; i++)
			{
				string dayOfWeek = dateTime.DayOfWeek.ToString();
				days[dayOfWeek]++;
				dateTime = dateTime.AddDays(1);
			}

			int maxFrequency = days.Values.Max();

			var mostFrequentDays = days.Where(x => x.Value == maxFrequency)
									.Select(x => x.Key)
									.OrderBy(day => Array.IndexOf(new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" }, day))
									.ToArray();

			return mostFrequentDays;
		}
	}
}
//https://www.codewars.com/kata/56eb16655250549e4b0013f4/train/csharp