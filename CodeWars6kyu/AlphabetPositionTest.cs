using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class AlphabetPositionTest
    {
        public static string AlphabetPosition(string text)
        {
            string result = "";

            foreach (var letter in text.ToUpper())
            {
                if (char.IsLetter(letter))
                {
                    int number = letter - 'A' + 1;

                    result += number.ToString() + " ";
                }

            }

            return result.Trim();
        }
    }
}
//https://www.codewars.com/kata/546f922b54af40e1e90001da/train/csharp
