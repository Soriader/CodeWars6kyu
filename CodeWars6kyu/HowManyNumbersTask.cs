using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class HowManyNumbersTask
    {
        public static int SelNumber(int n, int d)
        {
            if (n < 10)
            {
                return 0;
            }

            List<int> validNumbers = new List<int>();

            for (int actualNumber = 10; actualNumber <= n; actualNumber++)
            {
                if (IsValidNumber(actualNumber, d))
                {
                    validNumbers.Add(actualNumber);
                }
            }

            return validNumbers.Count;
        }

        private static bool IsValidNumber(int number, int maxDifference)
        {
            if (!HasUniqueDigits(number))
            {
                return false;
            }

            string numberStr = number.ToString();

            for (int i = 0; i < numberStr.Length - 1; i++)
            {
                int currentDigit = int.Parse(numberStr[i].ToString());
                int nextDigit = int.Parse(numberStr[i + 1].ToString());

                if (currentDigit >= nextDigit)
                {
                    return false;
                }

                if (Math.Abs(currentDigit - nextDigit) > maxDifference)
                {
                    return false;
                }
            }

            return true; 
        }

        private static bool HasUniqueDigits(int number)
        {
            var digits = new HashSet<char>();
            foreach (char digit in number.ToString())
            {
                if (!digits.Add(digit)) 
                {
                    return false;
                }
            }
            return true;
        }

    }
}
//https://www.codewars.com/kata/55d8aa568dec9fb9e200004a/train/csharp