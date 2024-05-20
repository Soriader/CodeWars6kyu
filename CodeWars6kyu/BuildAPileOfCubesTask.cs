using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class BuildAPileOfCubesTask
    {
        public static long findNb(long m)
        {
            long iterator = 1;
            long result = 0;

            while (result < m)
            {
                result += iterator * iterator * iterator;
                iterator++;
            }

            return (result == m) ? iterator - 1 : -1;
        }
    }
}
//https://www.codewars.com/kata/5592e3bd57b64d00f3000047/train/csharp