using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class DataReverseTask
    {
        public static int[] DataReverse(int[] data)
        {
            int[] reversedData = new int[data.Length];

            int segmentLength = 8;
            int segmentsCount = data.Length / segmentLength;

            for (int i = 0; i < segmentsCount; i++)
            {
                Array.Copy(data, i * segmentLength, reversedData, (segmentsCount - i - 1) * segmentLength, segmentLength);
            }

            return reversedData;
        }
    }
}
//https://www.codewars.com/kata/569d488d61b812a0f7000015/train/csharp