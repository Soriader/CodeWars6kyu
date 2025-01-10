using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class SnakesAndLaddersTask
    {
        public static int SnakesAndLadders(int[] board, int[] dice)
        {
            int position = 0;

            for (int i = 0; i < dice.Length; i++)
            {
                if (position + dice[i] + 1 > board.Length)
                {
                    continue;
                }
                else
                {
                    position += dice[i];
                    position += board[position];
                }
            }

            return position;
        }
    }
}
//https://www.codewars.com/kata/5821cd4770ca285b1f0001d5/train/csharp