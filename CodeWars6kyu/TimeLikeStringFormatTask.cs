using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class TimeLikeStringFormatTask
    {
        public static string FormatTime(int hour)
        {
            var parse = hour.ToString();


            if (parse.Length == 3)
            {
                return $"{parse[0]}:{parse[1]}{parse[2]}";
            }
            else if (parse.Length == 4) 
            {
                return $"{parse[0]}{parse[1]}:{parse[2]}{parse[3]}";
            }

            throw new ArgumentException(String.Format("Number length is longer than 4"));

        }
    }
}
//https://www.codewars.com/kata/51e000d070fe4414000003f0/train/csharp