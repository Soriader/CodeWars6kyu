using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class BuildTowerTask
    {
        public static string[] TowerBuilder(int nFloors)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < nFloors; i++)
            {
                string spaces = new string(' ', nFloors - i - 1);
                string stars = new string('*', 2 * i + 1);
                result.Add(spaces + stars + spaces);
            }

            return result.ToArray();
        }
    }
}
