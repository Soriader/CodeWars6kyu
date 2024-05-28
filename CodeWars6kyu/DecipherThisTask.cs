using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class DecipherThisTask
    {
        public static string DecipherThis(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }

            string[] words = s.Split(' ');
            List<string> decipheredWords = new List<string>();

            foreach (string word in words)
            {
                if (string.IsNullOrEmpty(word))
                {
                    continue;
                }

                string numStr = "";
                int i = 0;

                while (i < word.Length && char.IsDigit(word[i]))
                {
                    numStr += word[i];
                    i++;
                }

                if (string.IsNullOrEmpty(numStr))
                {
                    continue;
                }

                char firstLetter = (char)int.Parse(numStr);

                string restOfWord = word.Substring(i);

                if (restOfWord.Length > 1)
                {
                    char[] chars = restOfWord.ToCharArray();
                    char temp = chars[0];
                    chars[0] = chars[chars.Length - 1];
                    chars[chars.Length - 1] = temp;
                    restOfWord = new string(chars);
                }

                decipheredWords.Add(firstLetter + restOfWord);
            }

            string decipheredMessage = string.Join(" ", decipheredWords);

            return decipheredMessage;

        }
    }
}
//https://www.codewars.com/kata/581e014b55f2c52bb00000f8/train/csharp