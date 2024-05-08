using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class StreetFighterCharacterSelectionTask
    {
        public static string[] StreetFighterSelection(string[][] fighters, int[] position, string[] moves)
        {
            int rowIndex = position[0];
            int colIndex = position[1];
            List<string> hoveredFighters = new List<string>();

            foreach (var move in moves)
            {
                switch (move)
                {
                    case "up":
                        if (rowIndex > 0) rowIndex--;
                        break;
                    case "down":
                        if (rowIndex < fighters.Length - 1) rowIndex++;
                        break;
                    case "left":
                        colIndex = (colIndex == 0) ? fighters[rowIndex].Length - 1 : colIndex - 1;
                        break;
                    case "right":
                        colIndex = (colIndex == fighters[rowIndex].Length - 1) ? 0 : colIndex + 1;
                        break;
                }

                hoveredFighters.Add(fighters[rowIndex][colIndex]);
            }

            return hoveredFighters.ToArray();

        }
    }
}
//https://www.codewars.com/kata/5853213063adbd1b9b0000be/train/csharp