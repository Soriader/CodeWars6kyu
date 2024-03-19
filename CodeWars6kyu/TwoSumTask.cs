using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class TwoSumTask
    {
        public static int[] TwoSum(int[] numbers, int target)
        {

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if(i+1 < numbers.Length)
                {

                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[j] + numbers[i] == target)
                        {
                            return new int[] {i, j};
                        }
                    }
                }

            }

            return null;
        }
    }
}
//https://www.codewars.com/kata/52c31f8e6605bcc646000082/train/csharp