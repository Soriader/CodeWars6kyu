using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class MakeAWindowTask
	{
		public static string MakeAWindow(int num)
		{
			string glass = $"|{String.Concat(Enumerable.Repeat(".", num))}|{String.Concat(Enumerable.Repeat(".", num))}|\n";
			string endOfWindow = String.Concat(Enumerable.Repeat("-", glass.Length - 1)) + "\n";
			string centerOfWindow = $"|{String.Concat(Enumerable.Repeat("-", num))}+{String.Concat(Enumerable.Repeat("-", num))}|\n";
			string result = endOfWindow;

			for (int i = 1; i <= num * 2; i++) 
			{
				result += glass;
				
				if(i == num)
				{
					result += centerOfWindow;
				}
			}

			result += endOfWindow;

			return result.TrimEnd('\n');
		}
	}
}
//https://www.codewars.com/kata/59c03f175fb13337df00002e/train/csharp