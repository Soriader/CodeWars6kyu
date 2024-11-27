using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class EsolangTickTask
	{
		public static string Interpret(string tape)
		{
			List<int> memory = new List<int> { 0 }; 
			int position = 0;
			string result = "";

			foreach (char command in tape)
			{
				switch (command)
				{
					case '>':
						position++;
						if (position == memory.Count)
						{
							memory.Add(0); 
						}
						break;

					case '<':
						position--;
						if (position < 0)
						{
							memory.Insert(0, 0);
							position = 0;
						}
						break;

					case '+':
						memory[position] = (memory[position] + 1) % 256;
						break;

					case '*':
						result += (char)memory[position];
						break;
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/587edac2bdf76ea23500011a/train/csharp
