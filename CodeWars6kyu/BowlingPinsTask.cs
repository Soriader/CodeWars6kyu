using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class BowlingPinsTask
    {
		public string BowlingPins(int[] arr)
		{
			int[] firstLine = new int[] { 7, 8, 9, 10 };
			int[] secondLine = new int[] { 4, 5, 6 };
			int[] thirdLine = new int[] { 2, 3 };
			int[] fourthLine = new int[] { 1 };

			string result = "";
			result += GenerateLine(firstLine, arr, 0) + "\n";
			result += GenerateLine(secondLine, arr, 1) + "\n";
			result += GenerateLine(thirdLine, arr, 2) + "\n";
			result += GenerateLine(fourthLine, arr, 3);

			return result;
		}

		private string GenerateLine(int[] pins, int[] arr, int leadingSpaces)
		{
			string line = new string(' ', leadingSpaces);
			foreach (int pin in pins)
			{
				line += arr.Contains(pin) ? " " : "I";
				line += " ";
			}
			line = line.TrimEnd();

			return line.PadRight(7, ' ');
		}
	}
}
//https://www.codewars.com/kata/585cf93f6ad5e0d9bf000010/train/csharp