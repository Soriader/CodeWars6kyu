using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace CodeWars6kyu
{
    public class ArrayDiffTask
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            int[] c = {};

            foreach (int value in a)
            {
                if (!b.Contains(value))
                {
                    c = c.Concat(new int[] { value }).ToArray();
                }
            }

            return c;
        }
    }
}
// https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp
