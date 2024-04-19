using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class TortoiseRacingTask
    {
        public static int[] Race(int v1, int v2, int g)
        {
            if(v1 >= v2)
            {
                return null;
            }

            int timeToCatchInSeconds = g * 3600 / (v2 - v1);

            int hours = timeToCatchInSeconds / 3600;
            int minutes = (timeToCatchInSeconds % 3600) / 60;
            int seconds = timeToCatchInSeconds % 60;

            return new int[] { hours, minutes, seconds };

            
        }
    }
}
//https://www.codewars.com/kata/55e2adece53b4cdcb900006c/train/csharp