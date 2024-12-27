using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class EliminationTournamentTask
    {
        public static int[][] Tourney(int[] arr)
        {
            var results = new List<int[]>();

            var currentRound = arr.ToArray();

            results.Add(currentRound);

            while (currentRound.Length > 1)
            {
                var nextRound = new List<int>();

                for (int i = 0; i < currentRound.Length; i += 2)
                {
                    if (i + 1 < currentRound.Length)
                    {
                        nextRound.Add(Math.Max(currentRound[i], currentRound[i + 1]));
                    }
                    else
                    {
                        nextRound.Insert(0, currentRound[i]);
                    }
                }

                currentRound = nextRound.ToArray();
                results.Add(currentRound);
            }

            return results.ToArray();
        }
    }
}
//https://www.codewars.com/kata/5f631ed489e0e101a70c70a0/train/csharp