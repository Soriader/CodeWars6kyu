using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class MovesInSquaredStringsTask
	{
		public static string Rot(string strng)
		{
			var lines = strng.Split('\n'); 
			var reversedLines = lines.Select(line => new string(line.Reverse().ToArray())).Reverse();
			return string.Join("\n", reversedLines);
		}
		public static string SelfieAndRot(string strng)
		{
			var lines = strng.Split('\n');
			int len = lines[0].Length; 

			var selfie = lines.Select(line => line + new string('.', len));

			var rot = Rot(strng).Split('\n');
			var rotWithDots = rot.Select(line => new string('.', len) + line);

			return string.Join("\n", selfie.Concat(rotWithDots));
		}
		public static string Oper(Func<string, string> fct, string s)
		{
			return fct(s);
		}
	}
}
//https://www.codewars.com/kata/56dbe7f113c2f63570000b86/train/csharp