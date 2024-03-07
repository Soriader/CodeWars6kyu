using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class TakeATenMinutesWalkTest
    {
        public static bool IsValidWalk(string[] walk)
        {
            string concatenatedWalk = string.Join("", walk);

            char[] walkDistance = concatenatedWalk.ToCharArray();

            int x = 0;
            int y = 0;

            foreach (char distance in walkDistance)
            {
                if (distance == 'n')
                    y++;
                else if (distance == 's')
                    y--;
                else if (distance == 'e')
                    x++;
                else if (distance == 'w')
                    x--;
            }

            return x == 0 && y == 0 && walkDistance.Length == 10;

        }
    }
}
//https://www.codewars.com/kata/54da539698b8a2ad76000228/train/csharp