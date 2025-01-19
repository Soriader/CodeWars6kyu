using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class FindNumbersWithSameAmountOfDivisorsTask
    {
        private static Dictionary<long, int> CountOfDivisors = new Dictionary<long, int>();
        public static int CountPairsInt(int diff, long nMax)
        {
            int result = 0;

            for (long i = 1; i < nMax; i++)
            {
                CountOfDivisors[i] = FindAllDivisors(i);
            }

            foreach (var firstPair in CountOfDivisors)
            {
                long secondKey = firstPair.Key + diff; 

                if (secondKey < nMax && CountOfDivisors.ContainsKey(secondKey) &&
                    CountOfDivisors[firstPair.Key] == CountOfDivisors[secondKey])
                {
                    result++;
                }
            }

            return result;
        }

        public static int FindAllDivisors(long number)
        {
            int count = 0;

            for (int i = 1; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    count++;

                    if (i != number / i)
                    {
                        count++; 
                    }
                }
            }

            return count;
        }
    }
}
//https://www.codewars.com/kata/55f1614853ddee8bd4000014/train/csharp