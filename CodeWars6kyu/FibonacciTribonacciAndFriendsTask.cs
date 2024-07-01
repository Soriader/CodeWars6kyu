using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class FibonacciTribonacciAndFriendsTask
    {
        public static double[] Xbonacci(double[] signature, int n)
        {
            List<double> result = new List<double>(signature);

            if (n <= signature.Length)
            {
                return signature.Take(n).ToArray();
            }

            for (int i = signature.Length; i < n; i++)
            {
                double nextElement = 0;
                for (int j = i - signature.Length; j < i; j++)
                {
                    nextElement += result[j];
                }

                result.Add(nextElement);
            }

            return result.ToArray();
        }
    }
}
//https://www.codewars.com/kata/556e0fccc392c527f20000c5/train/csharp