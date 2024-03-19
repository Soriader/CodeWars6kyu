using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class SortTheOddTask
    {
        public static int[] SortArray(int[] array)
        {
            Queue<int> odd = new Queue<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 != 0)
                {
                    odd.Enqueue(array[i]);
                }
            }

            Queue<int> sortedOdd = new Queue<int>();

            foreach (var item in odd.OrderBy(x => x))
            {
                sortedOdd.Enqueue(item);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    array[i] = sortedOdd.Dequeue();
                }
            }

            return array;
        }
    }
}
//https://www.codewars.com/kata/578aa45ee9fd15ff4600090d/train/csharp