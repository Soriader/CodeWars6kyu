using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class UniqueInOrderTask
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            T previous = default(T);
            bool first = true;

            foreach (T current in iterable)
            {
                if (first || !current.Equals(previous))
                {
                    yield return current;
                    first = false;
                }
                previous = current;
            }

        }
    }
}
//https://www.codewars.com/kata/54e6533c92449cc251001667/train/csharp