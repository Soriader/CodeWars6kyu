using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class MiniBitMoveTask
	{
		public static bool[] Interpreter(string code, bool[] array)
		{
			int selector = 0; 
			int programLength = code.Length;

			while (selector < array.Length)
			{
				foreach (char command in code)
				{
					if (selector >= array.Length)
					{
						break;
					}

					if (command == '1')
					{
						array[selector] = !array[selector];
					}
					else if (command == '0')
					{
						selector++;
					}
				}
			}

			return array;
		}
	}
}
//https://www.codewars.com/kata/587c0138110b20624e000253/train/csharp