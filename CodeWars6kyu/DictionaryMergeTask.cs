using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class DictionaryMergeTask
    {
        public static Dictionary<TKey, TValue[]> Merge<TKey, TValue>(params Dictionary<TKey, TValue>[] dicts)
        {
            var result = new Dictionary<TKey, List<TValue>>();

            foreach (var dict in dicts)
            {
                foreach (var kvp in dict)
                {
                    if (!result.ContainsKey(kvp.Key))
                    {
                        result[kvp.Key] = new List<TValue>();
                    }
                    result[kvp.Key].Add(kvp.Value);
                }
            }

            return result.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.ToArray());
        }
    }
}
//https://www.codewars.com/kata/5ae840b8783bb4ef79000094/train/csharp