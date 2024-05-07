using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class DeleteOccurrencesTask
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            List<int> result = new List<int>();
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (!counts.ContainsKey(num))
                {
                    counts[num] = 1;
                    result.Add(num);
                }
                else
                {
                    if (counts[num] < x)
                    {
                        counts[num]++;
                        result.Add(num);
                    }
                }
            }

            return result.ToArray();
        }
    }
}
//https://www.codewars.com/kata/554ca54ffa7d91b236000023/train/csharp