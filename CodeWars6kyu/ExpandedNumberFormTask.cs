using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars6kyu
{
    public class ExpandedNumberFormTask
    {
        public static string ExpandedForm(long num)
        {
            if (num == 0)
            {
                return "0";
            }

            string result = "";

            long remaining = num;
            long divider = 1;

            while (remaining > 0)
            {
                long digit = remaining % 10;
                remaining /= 10;

                if (digit > 0)
                {
                    result = $"{digit * divider} + {result}";
                }

                divider *= 10;
            }

            return result.Substring(0, result.Length - 3);
        }
    }
}
//https://www.codewars.com/kata/5842df8ccbd22792a4000245/train/csharp