using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class FindTheUniqueNumberTask
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            var groups = numbers.GroupBy(x => x);

            foreach (var group in groups)
            {
                if (group.Count() == 1)
                {
                    return group.Key;
                }
            }

            return 0;
        }
    }
}
