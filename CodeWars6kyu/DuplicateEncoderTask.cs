using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class DuplicateEncoderTask
    {
        public static string DuplicateEncode(string word)
        {
            word = word.ToLower();
            string result = "";
            foreach (char c in word)
            {
                if (word.Count(x => x == c) > 1)
                {
                    result += ")";
                }
                else
                {
                    result += "(";
                }
            }
            return result;
        }
    }
}
//https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp