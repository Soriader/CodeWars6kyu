using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class MexicanWaveTask
    {
        public static List<string> Wave(string str)
        {
            var result = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    string wavedString = str.Substring(0, i) + Char.ToUpper(str[i]) + str.Substring(i + 1);
                    result.Add(wavedString);
                }
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/58f5c63f1e26ecda7e000029/train/csharp