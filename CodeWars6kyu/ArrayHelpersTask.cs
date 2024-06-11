using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class ArrayHelpersTask
    {
        public static int[] Square(int[] array)
        {
            return array.Select(x => x * x).ToArray();
        }

        public static int[] Cube(int[] array)
        {
            return array.Select(x => x * x * x).ToArray();
        }

        public static double Average(int[] array)
        {
            return array.Length == 0 ? double.NaN : array.Average();
        }

        public static int Sum(int[] array)
        {
            return array.Sum();
        }

        public static int[] Even(int[] array)
        {
            return array.Where(x => x % 2 == 0).ToArray();
        }

        public static int[] Odd(int[] array)
        {
            return array.Where(x => x % 2 != 0).ToArray();
        }

    }
}
