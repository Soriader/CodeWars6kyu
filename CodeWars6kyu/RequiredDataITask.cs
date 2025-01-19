using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class RequiredDataITask
    {
        public static object[] CountSel(int[] lst)
        {
            if (lst == null || lst.Length == 0)
            {
                return new object[] { 0, 0, 0, new object[] { new int[] { }, 0 } };
            }

            int totalCount = lst.Length;
            int uniqueCount = SecondCondition(lst);
            int singleOccurrenceCount = ThirdCondition(lst);
            object[] maxOccurrences = FourthAndFifthCondition(lst);

            return new object[] { totalCount, uniqueCount, singleOccurrenceCount, maxOccurrences };
        }

        private static int SecondCondition(int[] lst)
        {
            return lst.Distinct().Count();
        }

        private static int ThirdCondition(int[] lst)
        {
            var occurrences = lst.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
            return occurrences.Count(pair => pair.Value == 1);
        }
        private static object[] FourthAndFifthCondition(int[] lst)
        {
            var occurrences = lst.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
            int maxOccurrence = occurrences.Values.Max();

            var maxValues = occurrences
                .Where(pair => pair.Value == maxOccurrence)
                .Select(pair => pair.Key)
                .OrderBy(x => x)
                .ToArray();

            return new object[] { maxValues, maxOccurrence };
        }

    }
}
//https://www.codewars.com/kata/55f95dbb350b7b1239000030/train/csharp