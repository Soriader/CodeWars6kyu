using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class SimpleSumOfPairsTask
    {
        public static int Solve(long n)
        {
            if (n < 10)
            {
                return (int)n;

            }

            var a = long.Parse(new string(n.ToString().Skip(1).ToArray())) + 1;
            var b = n - a;

            return $"{a}{b}".Sum(c => c - '0');
        }
    }
}
//https://www.codewars.com/kata/5bc027fccd4ec86c840000b7/train/csharp