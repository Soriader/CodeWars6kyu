using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class HollowArrayTask
    {
        public static bool IsHollow(int[] x)
        {
            int firstZeroIndex = Array.IndexOf(x, 0);
            int lastZeroIndex = Array.LastIndexOf(x, 0);

            if (lastZeroIndex - firstZeroIndex + 1 < 3)
            {
                return false;

            }

            for (int i = firstZeroIndex; i <= lastZeroIndex; i++)
            {
                if (x[i] != 0)
                {
                    return false;

                }
            }

            int leftNonZeros = firstZeroIndex;
            int rightNonZeros = x.Length - lastZeroIndex - 1;

            return leftNonZeros == rightNonZeros;
        }
    }
}
//https://www.codewars.com/kata/59b72376460387017e000062/train/csharp