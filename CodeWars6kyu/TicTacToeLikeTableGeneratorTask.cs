using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class TicTacToeLikeTableGeneratorTask
	{
		public static string DisplayBoard(char[] board, int width)
		{
			var howManySeparatorsAdded = (width * 3) + (width - 1);
			var part ="\n" + String.Concat(Enumerable.Repeat("-", howManySeparatorsAdded)) + "\n";
			int iterator = 1;
			string result = "";

			for (int i = 0; i < board.Length; i++) 
			{
				if (i == board.Length - 1)
				{
					result += $" {board[i]} ";
					break ;
				}
				else if(iterator == width)
				{
					result += $" {board[i]} ";
					result += part;
					iterator = 1;
				}
				else
				{
					result += $" {board[i]} |";
					iterator++;
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/5b817c2a0ce070ace8002be0/train/csharp