using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class RemoveTheParenthesesTask
    {
        public static string RemoveParentheses(string s)
        {

            var check = s.ToCharArray();
            string result = "";
            int parenthesesLevel = 0;

            foreach (char c in check)
            {
                if (c == '(')
                {
                    parenthesesLevel++;
                }
                else if (c == ')')
                {
                    if (parenthesesLevel > 0)
                    {
                        parenthesesLevel--;
                    }
                }
                else
                {
                    if (parenthesesLevel == 0)
                    {
                        result += c;
                    }
                }
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/5f7c38eb54307c002a2b8cc8/train/csharp