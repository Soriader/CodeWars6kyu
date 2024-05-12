using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class AddOneArrayTask
    {
        public static int[] UpArray(int[] num)
        {
            if (num.Length == 0 || num.Any(n => n < 0 || n > 9))
            {
                return null;
            }

            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] < 9)
                {
                    num[i]++;
                    return num;
                }

                num[i] = 0;
            }


            int[] result = new int[num.Length + 1];
            result[0] = 1; 
            return result;
        }
    }
}
//https://www.codewars.com/kata/5514e5b77e6b2f38e0000ca9/train/csharp