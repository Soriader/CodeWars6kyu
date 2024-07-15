using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class EurekaTask
    {
        public static long[] SumDigPow(long a, long b)
        {
            List<long> result = new List<long>();

            for (long num = a; num <= b; num++)
            {
                if (IsEureka(num))
                {
                    result.Add(num);
                }
            }

            return result.ToArray();
        }

        private static bool IsEureka(long num)
        {
            string numStr = num.ToString();
            long sum = 0;

            for (int i = 0; i < numStr.Length; i++)
            {
                int digit = (int)char.GetNumericValue(numStr[i]);
                sum += (long)Math.Pow(digit, i + 1);
            }

            return sum == num;
        }
    }
}
