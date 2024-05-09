using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class EncryptThisTask
    {
        public static string EncryptThis(string input)
        {
            string[] words = input.Split(' ');

            StringBuilder encryptedMessage = new StringBuilder();

            foreach (string word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    int asciiCode = (int)word[0];
                    string encryptedWord = asciiCode.ToString();

                    if (word.Length > 1)
                    {
                        char[] letters = word.ToCharArray();
                        char temp = letters[1];
                        letters[1] = letters[word.Length - 1];
                        letters[word.Length - 1] = temp;

                        encryptedWord += new string(letters, 1, word.Length - 1);
                    }

                    encryptedMessage.Append(encryptedWord + " ");
                }
            }

            return encryptedMessage.ToString().Trim();
        }
    }
}
//https://www.codewars.com/kata/5848565e273af816fb000449/train/csharp