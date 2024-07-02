using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class ExtractPortionOfFileNameTask
    {
        public static string ExtractFileName(string dirtFileName)
        {
            var regex = new Regex(@"^[^_]+_(.+?\..+?)(?:\..+)+$");

            var match = regex.Match(dirtFileName);

            if (match.Success)
            {
                return match.Groups[1].Value;
            }

            return string.Empty;
        }
    }
}
//https://www.codewars.com/kata/597770e98b4b340e5b000071/train/csharp