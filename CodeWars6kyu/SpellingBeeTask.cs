using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class SpellingBeeTask
	{
		public static int HowManyBees(char[][] hive)
		{
			if (hive == null || hive.Length == 0) return 0;

			int result = 0;
			int rows = hive.Length;
			int cols = hive[0].Length;

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (j + 2 < cols && hive[i][j] == 'b' && hive[i][j + 1] == 'e' && hive[i][j + 2] == 'e')
					{
						result++;

					}

					if (j - 2 >= 0 && hive[i][j] == 'b' && hive[i][j - 1] == 'e' && hive[i][j - 2] == 'e')
					{
						result++;

					}
					if (i + 2 < rows && hive[i][j] == 'b' && hive[i + 1][j] == 'e' && hive[i + 2][j] == 'e')
					{
						result++;

					}
					if (i - 2 >= 0 && hive[i][j] == 'b' && hive[i - 1][j] == 'e' && hive[i - 2][j] == 'e')
					{
						result++;

					}
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/57d6b40fbfcdc5e9280002ee/train/csharp