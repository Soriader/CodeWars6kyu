using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class MinutesToMidnightTask
    {
        public string CountMinutes(DateTime d)
        {
            DateTime midnight = d.Date.AddDays(1);
            TimeSpan timeUntilMidnight = midnight - d;

            int minutes = (int)Math.Round(timeUntilMidnight.TotalMinutes);

            return minutes == 1 ? $"{minutes} minute" : $"{minutes} minutes";

        }
    }
}
//https://www.codewars.com/kata/58528e9e22555d8d33000163/train/csharp