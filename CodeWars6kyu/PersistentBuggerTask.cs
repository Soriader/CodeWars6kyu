using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars6kyu
{
    public class PersistentBuggerTask
    {
        public static int Persistence(long n)
        {
            if (n < 10)
            {
                return 0;
            }

            int iteration = 0;

            while (n >= 10)
            {
                int product = 1;

                while (n > 0)
                {
                    product *= (int)n % 10;
                    n /= 10;
                }
                iteration++;
                n = product;
            }

            return iteration;
        }
    }
}
//https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec/train/csharp