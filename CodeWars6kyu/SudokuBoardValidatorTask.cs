using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class SudokuBoardValidatorTask
	{
		public static bool Validate(int[][] board)
		{
			if (board.Any(row => row.Contains(0)))
			{
				return false;
			}

			foreach (var row in board)
			{
				if (!IsValidSet(row))
				{
					return false;
				}
			}

			for (int col = 0; col < 9; col++)
			{
				int[] column = Enumerable.Range(0, 9).Select(row => board[row][col]).ToArray();
				if (!IsValidSet(column))
				{
					return false;
				}
			}

			for (int row = 0; row < 9; row += 3)
			{
				for (int col = 0; col < 9; col += 3)
				{
					int[] block = Enumerable.Range(0, 3)
						.SelectMany(r => Enumerable.Range(0, 3).Select(c => board[row + r][col + c]))
						.ToArray();

					if (!IsValidSet(block))
					{
						return false;

					}
				}
			}

			return true;
		}

		private static bool IsValidSet(int[] numbers)
		{
			return numbers.OrderBy(n => n).SequenceEqual(Enumerable.Range(1, 9));
		}
	}
}
//https://www.codewars.com/kata/63d1bac72de941033dbf87ae/train/csharp