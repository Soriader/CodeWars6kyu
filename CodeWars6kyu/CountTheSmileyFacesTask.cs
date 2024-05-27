using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class CountTheSmileyFacesTask
    {
        public static int CountSmileys(string[] smileys)
        {
            int smilesCount = 0;

            string pattern = @"[:;][-~]?[)D]";

            foreach (string smile in smileys)
            {
                if (Regex.IsMatch(smile, pattern))
                {
                    smilesCount++;
                }
            }

            return smilesCount;
        }
    }
}
//https://www.codewars.com/kata/583203e6eb35d7980400002a/train/csharp