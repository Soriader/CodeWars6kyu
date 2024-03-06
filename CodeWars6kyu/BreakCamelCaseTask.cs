using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class BreakCamelCaseTask
    {
        public static string BreakCamelCase(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i];

                if (char.IsUpper(currentChar))
                {
                    result += " " + currentChar;
                }
                else
                {
                    result += currentChar;
                }
            }

            return result.Trim();
        }
    }
}
//https://www.codewars.com/kata/5208f99aee097e6552000148/train/csharp