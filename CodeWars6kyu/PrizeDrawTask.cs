using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class PrizeDrawTask
    {
        public static string NthRank(string st, int[] we, int n)
        {

            if (string.IsNullOrWhiteSpace(st)) return "No participants";

            var names = st.Split(',');

            if (names.Length < n) return "Not enough participants";

            var participants = new List<Tuple<string, int>>();

            for (int i = 0; i < names.Length; i++)
            {
                var name = names[i];
                var som = name.Length + name.ToLower().Sum(c => c - 'a' + 1);
                var winningNumber = som * we[i];
                participants.Add(Tuple.Create(name, winningNumber));
            }

            var sortedParticipants = participants
                .OrderByDescending(p => p.Item2)
                .ThenBy(p => p.Item1)
                .ToList();

            return sortedParticipants[n - 1].Item1;
        }
    }
}
//https://www.codewars.com/kata/5616868c81a0f281e500005c/train/csharp