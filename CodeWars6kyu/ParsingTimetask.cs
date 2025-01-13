using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class ParsingTimeTask
    {
        public static int? ToSeconds(string time)
        {
            int result = 0;
            var timePart = time.Split(':');


            if (timePart.Length != 3 
                || timePart[0].Length != 2 
                || timePart[1].Length != 2 
                || timePart[2].Length != 2 
                || int.Parse(timePart[2]) > 59 
                || int.Parse(timePart[1]) > 59)
            {
                return null;
            }


            result = int.Parse(timePart[0]) * 3600 
                + int.Parse(timePart[1]) * 60 
                + int.Parse(timePart[2]);

            return result;
        }
    }
}
//https://www.codewars.com/kata/568338ea371e86728c000002/train/csharp