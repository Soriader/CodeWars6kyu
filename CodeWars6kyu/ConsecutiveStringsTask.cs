using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class ConsecutiveStringsTask
    {
        public static string LongestConsec(string[] strarr, int k)
        {
            if (k <= 0 || k > strarr.Length)
            {
                return ""; 
            }

            List<string> mergedWords = new List<string>();

            for (int i = 0; i <= strarr.Length - k; i++)
            {
                string mergedWord = string.Concat(strarr.Skip(i).Take(k));
                mergedWords.Add(mergedWord);
            }

            return mergedWords.OrderByDescending(w => w.Length).FirstOrDefault();
        }
    }
}
//https://www.codewars.com/kata/56a5d994ac971f1ac500003e/train/csharp