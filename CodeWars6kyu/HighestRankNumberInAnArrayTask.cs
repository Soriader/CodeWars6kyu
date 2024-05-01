using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class HighestRankNumberInAnArrayTask
    {
        public static int HighestRank(int[] arr)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int number in arr)
            {
                if (frequencyMap.ContainsKey(number))
                {
                    frequencyMap[number]++;
                }
                else
                {
                    frequencyMap[number] = 1;
                }
            }

            int mostFrequentNumber = arr[0];
            int maxFrequency = frequencyMap[arr[0]];

            foreach (var kvp in frequencyMap)
            {
                if (kvp.Value > maxFrequency || (kvp.Value == maxFrequency && kvp.Key > mostFrequentNumber))
                {
                    mostFrequentNumber = kvp.Key;
                    maxFrequency = kvp.Value;
                }
            }

            return mostFrequentNumber;

        }
    }
}
//https://www.codewars.com/kata/5420fc9bb5b2c7fd57000004/train/csharp