using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class AreTheyTheSameTask
    {
        public static bool Comp(int[] a, int[] b)
        {

            if (a == null || b == null || a.Length != b.Length)
            {
                return false;
            }

            Dictionary<int, int> squaresCount = new Dictionary<int, int>();

            foreach (int num in a)
            {
                int square = num * num;
                if (squaresCount.ContainsKey(square))
                {
                    squaresCount[square]++;
                }
                else
                {
                    squaresCount[square] = 1;
                }
            }

            foreach (int num in b)
            {
                if (squaresCount.ContainsKey(num) && squaresCount[num] > 0)
                {
                    squaresCount[num]--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
//https://www.codewars.com/kata/550498447451fbbd7600041c/train/csharp