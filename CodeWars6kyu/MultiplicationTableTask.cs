using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class MultiplicationTableTask
    {
        public static int[,] MultiplicationTable(int size)
        {
            int[,] table = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    table[i, j] = (i + 1) * (j + 1);
                }
            }

            return table;
        }
    }
}
//https://www.codewars.com/kata/534d2f5b5371ecf8d2000a08/train/csharp