using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class PossibilitiesOfThrowingACoinTask
	{
		public List<string> Coin(int n)
		{
			List<string> results = new List<string>();

			GenerateCombinations("", n, results);

			results.Sort();
			return results;
		}

		private void GenerateCombinations(string current, int remaining, List<string> results)
		{
			if (remaining == 0)
			{
				results.Add(current);
				return;
			}
			GenerateCombinations(current + "H", remaining - 1, results);
			GenerateCombinations(current + "T", remaining - 1, results);
		}
	}
}
//https://www.codewars.com/kata/5ad6266b673f2f067b000004/train/csharp