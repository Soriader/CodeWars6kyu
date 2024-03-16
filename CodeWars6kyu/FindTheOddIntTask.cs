using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars6kyu
{
    public class FindTheOddIntTask
    {
        public static int FindIt(int[] seq)
        {
            foreach (int num in seq)
            {
                if (seq.Count(x => x == num) % 2 != 0)
                {
                    return num;
                }
            }

            return 0;
        }
    }
}
//https://www.codewars.com/kata/54da5a58ea159efa38000836/train/csharp