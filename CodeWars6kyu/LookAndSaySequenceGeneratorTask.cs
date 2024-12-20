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

            var sequence = firstElement;

            for (int iterator = 1; iterator < n; iterator++)
            {
                string boxOfSequence = "";
                int i = 0;

                while (i < sequence.Length)
                {
                    char currentChar = sequence[i];
                    int countElement = 0;

                    while (i < sequence.Length && sequence[i] == currentChar)
                    {
                        countElement++;
                        i++;
                    }

                    boxOfSequence += $"{countElement}{currentChar}";
                }

                sequence = boxOfSequence;
            }

            return sequence;
        }
    }
}
//https://www.codewars.com/kata/592421cb7312c23a990000cf/train/csharp