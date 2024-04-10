using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class TribonacciSequenceTask
    {
        public static double[] Tribonacci(double[] signature, int n)
        {
            double[] result = new double[n];

            if (n <= 0)
            {
                return new double[0]; 
            }

            if (signature == null)
            {
                return result; 
            }

            for (int i = 0; i < 3; i++)
            {
                result[i] = signature[i];
            }

            for (int i = 3; i < n; i++)
            {
                result[i] = result[i - 1] + result[i - 2] + result[i - 3];
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/556deca17c58da83c00002db/train/csharp