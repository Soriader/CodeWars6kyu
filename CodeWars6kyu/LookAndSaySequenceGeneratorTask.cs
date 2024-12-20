using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class LookAndSaySequenceGeneratorTask
    {
        public static string LookAndSaySequence(string firstElement, long n)
        {
            if (n == 1)
            {
                return firstElement;
            }

            var result = firstElement;

            for (int iterator = 1; iterator < n; iterator++)
            {
                string boxOfSequence = "";
                int i = 0;

                while (i < result.Length)
                {
                    char currentChar = result[i];
                    int countElement = 0;

                    while (i < result.Length && result[i] == currentChar)
                    {
                        countElement++;
                        i++;
                    }

                    boxOfSequence += $"{countElement}{currentChar}";
                }

                result = boxOfSequence;
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/592421cb7312c23a990000cf/train/csharp