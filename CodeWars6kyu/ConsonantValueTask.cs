using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class ConsonantValueTask
    {
        public static int Solve(string s)
        {
            string vowels = "aeiou";
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int maxConsonantSum = 0;
            int currentConsonantSum = 0;

            foreach (char c in s)
            {
                if (!vowels.Contains(c))
                {
                    int index = alphabet.IndexOf(c) + 1;
                    if (index > 0)
                    {
                        currentConsonantSum += index;
                    }
                }
                else
                {
                    if (currentConsonantSum > maxConsonantSum)
                    {
                        maxConsonantSum = currentConsonantSum;
                    }
                    currentConsonantSum = 0;
                }
            }

            if (currentConsonantSum > maxConsonantSum)
            {
                maxConsonantSum = currentConsonantSum;
            }

            return maxConsonantSum;

        }
    }
}
//https://www.codewars.com/kata/59c633e7dcc4053512000073/train/csharp