using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class ThePlugboardTask
	{
		private Dictionary<char, char> letterPairs;

		public ThePlugboardTask(string wires = "")
		{
			letterPairs = new Dictionary<char, char>();

			if (wires.Length > 20)
			{
				throw new ArgumentException("Too many wires. Maximum is 10 pairs.");
			}

			for (int i = 0; i < wires.Length; i += 2)
			{
				char letter1 = wires[i];
				char letter2 = wires[i + 1];

				if (letterPairs.ContainsKey(letter1) || letterPairs.ContainsKey(letter2))
				{
					throw new ArgumentException("Letter already paired.");
				}

				letterPairs[letter1] = letter2;
				letterPairs[letter2] = letter1;
			}
		}

		public char Process(char c)
		{
			if (letterPairs.ContainsKey(c))
			{
				return letterPairs[c];
			}

			return c;
		}
	}
}
//https://www.codewars.com/kata/5523b97ac8f5025c45000900/train/csharp