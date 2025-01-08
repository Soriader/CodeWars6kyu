using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class ShorterPathTask
    {
        public static string[] Directions(string[] goal)
        {
            List<string> result = new List<string>();

            Dictionary<string, int> allDirections = new Dictionary<string, int>
        {
            { "N", 0 },
            { "S", 0 },
            { "E", 0 },
            { "W", 0 }
        };

            foreach (var c in goal)
            {
                if (allDirections.ContainsKey(c))
                {
                    allDirections[c]++;
                }
            }

            int northSouthDifference = allDirections["N"] - allDirections["S"];
            int eastWestDifference = allDirections["E"] - allDirections["W"];

            if (northSouthDifference > 0)
            {
                result.AddRange(new string[northSouthDifference].Select(_ => "N"));
            }
            else if (northSouthDifference < 0)
            {
                result.AddRange(new string[-northSouthDifference].Select(_ => "S"));
            }

            if (eastWestDifference > 0)
            {
                result.AddRange(new string[eastWestDifference].Select(_ => "E"));
            }
            else if (eastWestDifference < 0)
            {
                result.AddRange(new string[-eastWestDifference].Select(_ => "W"));
            }


            return result.ToArray();
        }
    }
}
//https://www.codewars.com/kata/56a14f18005af7002f00003f/train/csharp