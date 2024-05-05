using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class DetectPangramTask
    {
        public static bool IsPangram(string str)
        {
            bool[] alphabetUsed = new bool[26];

            foreach (char c in str.ToLower())
            {
                if (char.IsLetter(c))
                {
                    alphabetUsed[c - 'a'] = true;
                }
            }

            foreach (bool used in alphabetUsed)
            {
                if (!used)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
//https://www.codewars.com/kata/545cedaa9943f7fe7b000048/train/csharp
