using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class TheSupermarketQueueTask
    {
        public static long QueueTime(int[] customers, int n)
        {
            if (customers == null || customers.Length == 0)
                return 0;

            if (n == 1)
                return customers.Sum();

            long[] tills = new long[n];

            foreach (int customer in customers)
            {
                Array.Sort(tills);
                tills[0] += customer;
            }

            return tills.Max();
        }

    }
}
//https://www.codewars.com/kata/57b06f90e298a7b53d000a86/train/csharp