using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class CountCharactersInYourStringTask
    {
        public static Dictionary<char, int> Count(string str)
        {

            Dictionary<char, int> result = new ();
            var checkTheLetter = str.ToCharArray().ToList();
            var uniqueLetters = checkTheLetter.Distinct().ToList();

            foreach (var letter in uniqueLetters)
            {
                result.Add(letter, checkTheLetter.Where(x => x == letter).Count());
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/52efefcbcdf57161d4000091/train/csharp

