using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class EnglishBeggarsTask
    {
        public static int[] Beggars(int[] values, int n)
        {
            if (n == 0) return new int[] { };

            int[] result = new int[n];

            for (int i = 0; i < values.Length; i++)
            {
                result[i % n] += values[i];
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/59590976838112bfea0000fa/train/csharp