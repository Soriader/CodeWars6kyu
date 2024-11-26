using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class MissingKeyTask
	{
		public static Dictionary<char, int> letters = new Dictionary<char, int>()
			   {
					{'a', 1}, {'b', 2}, {'c', 3}, {'d', 4}, {'e', 5}, {'f', 6}, {'g', 7}, 
			        {'h', 8}, {'i', 9}, {'j', 10}, {'k', 11}, {'l', 12}, {'m', 13}, {'n', 14},
	                {'o', 15}, {'p', 16}, {'q', 17}, {'r', 18}, {'s', 19}, {'t', 20},
	                {'u', 21}, {'v', 22}, {'w', 23}, {'x', 24}, {'y', 25}, {'z', 26}
			   };
		public static int FindTheKey(string message, int[] code)
		{
			string sequence = "";

			for (int i = 0; i < message.Length; i++)
			{
				int difference = Math.Abs(letters[message[i]] - code[i]);

				sequence += difference;

			}

			for (int keyLength = 1; keyLength <= sequence.Length; keyLength++)
			{
				string potentialKey = sequence.Substring(0, keyLength);

				string repeatedKey = "";
				while (repeatedKey.Length < sequence.Length)
				{
					repeatedKey += potentialKey;
				}

				if (repeatedKey.Substring(0, sequence.Length) == sequence)
				{
					return int.Parse(potentialKey);
				}
			}

			throw new Exception("Key not exist.");

		}
	}
}
//https://www.codewars.com/kata/5930d8a4b8c2d9e11500002a/train/csharp