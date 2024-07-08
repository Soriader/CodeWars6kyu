using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class ReverseOrRotateTask
    {
        public static string RevRot(string strng, int sz)
        {
            if (sz <= 0 || strng == "" || sz > strng.Length) return "";

            StringBuilder result = new StringBuilder();

            for (int i = 0; i + sz <= strng.Length; i += sz)
            {
                string chunk = strng.Substring(i, sz);

                int sumOfDigits = 0;
                foreach (char digit in chunk)
                {
                    sumOfDigits += digit - '0'; 
                }

                if (sumOfDigits % 2 == 0)
                {
                    result.Append(ReverseString(chunk));
                }
                else
                {
                    result.Append(RotateLeft(chunk));
                }
            }

            return result.ToString();
        }

        private static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static string RotateLeft(string s)
        {
            return s.Substring(1) + s[0];
        } 
    }
}
//https://www.codewars.com/kata/56b5afb4ed1f6d5fb0000991/train/csharp