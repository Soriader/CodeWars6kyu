using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class GiveMeADiamondTask
    {
        public static string Print(int n)
        {
            if (n % 2 == 0 || n < 0)
            {
                return null;
            }

            string result = "";

            for (int i = 0; i < n / 2 + 1; i++)
            {
                result += new string(' ', n / 2 - i) + new string('*', 2 * i + 1) + "\n";
            }

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                result += new string(' ', n / 2 - i) + new string('*', 2 * i + 1) + "\n";
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/5503013e34137eeeaa001648/train/csharp