using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class DuplicateCountTask
    {
        public static int DuplicateCount(string str)
        {
            var letters = str.ToLower().ToCharArray();

            var dict = new Dictionary<char, int>();

            foreach (char c in letters.Distinct())
            {
                dict.Add(c, 0);
            }

            foreach (var c in letters)
            {
                dict[c] += 1;
            }

            return dict.Where(w => w.Value > 1).Count();
        }
    }
}
//https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1/train/csharp