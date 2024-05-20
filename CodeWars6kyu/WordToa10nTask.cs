using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class WordToa10nTask
    {
        public static string Abbreviate(string input)
        {
            List<string> result = new List<string>();
            int wordStart = -1;

            for (int i = 0; i <= input.Length; i++)
            {
                if (i < input.Length && char.IsLetter(input[i]))
                {
                    if (wordStart == -1)
                    {
                        wordStart = i;
                    }
                }
                else
                {
                    if (wordStart != -1)
                    {
                        int wordLength = i - wordStart;
                        if (wordLength >= 4)
                        {
                            result.Add($"{input[wordStart]}{wordLength - 2}{input[i - 1]}");
                        }
                        else
                        {
                            result.Add(input.Substring(wordStart, wordLength));
                        }
                        wordStart = -1;
                    }
                    if (i < input.Length)
                    {
                        result.Add(input[i].ToString());
                    }
                }
            }

            return string.Join("", result);
        }
    }
}
//https://www.codewars.com/kata/5375f921003bf62192000746/train/csharp