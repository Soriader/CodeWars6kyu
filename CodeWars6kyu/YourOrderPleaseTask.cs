using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class YourOrderPleaseTask
    {
        public static string Order(string words)
        {
            return string.IsNullOrEmpty(words) ? "" :
                           string.Join(" ", words.Split().OrderBy(w => int.Parse(new string(w.Where(char.IsDigit).ToArray()))));

        }
    }
}
//https://www.codewars.com/kata/55c45be3b2079eccff00010f/train/csharp