using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class ArrayDeepCountTask
    {
        public static int DeepCount(object a)
        {
            if (a is IEnumerable enumerable && !(a is string))
            {
                int count = 0;

                foreach (var element in enumerable)
                {
                    count++; 

                    if (element is IEnumerable && !(element is string))
                    {
                        count += DeepCount(element);
                    }
                }

                return count;
            }
            else
            {
                return 0;
            }
        }
    }
}
//https://www.codewars.com/kata/596f72bbe7cd7296d1000029/train/csharp