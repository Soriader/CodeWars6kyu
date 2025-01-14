using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class NumberOfMeasurementsCoinTask
    {
        public static long HowManyMeasurements(long n)
        {
            int result = 0;
            int power = 1;

            while (power < n)
            {
                result++;
                power *= 3;
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/59530d2401d6039f8600001f/train/csharp