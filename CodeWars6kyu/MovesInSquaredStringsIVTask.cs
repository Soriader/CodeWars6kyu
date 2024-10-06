using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class MovesInSquaredStringsIVTask
	{
		public static string Rot90Counter(string strng)
		{
			var check = strng.Split("\n"); 
			string result = "";
			int length = check.Length;

			for (int i = length - 1; i >= 0; i--) 
			{
				for (int j = 0; j < length; j++) 
				{
					result += check[j][i];
				}
				if (i > 0)
				{
					result += "\n"; 
				}
			}

			return result;
		}
		public static string Diag2Sym(string strng)
		{
			var check = strng.Split("\n"); 
			string result = "";
			int n = check.Length;

			for (int i = 0; i < n; i++) 
			{
				for (int j = 0; j < n; j++) 
				{
					result += check[n - j - 1][n - i - 1]; 
				}
				if (i < n - 1) 
				{
					result += "\n";
				}
			}

			return result;
		}
		public static string SelfieDiag2Counterclock(string strng)
		{
			var original = strng.Split("\n");
			var diag2 = Diag2Sym(strng).Split("\n");
			var rot90 = Rot90Counter(strng).Split("\n");

			string result = "";
			for (int i = 0; i < original.Length; i++)
			{
				result += $"{original[i]}|{diag2[i]}|{rot90[i]}";
				if (i < original.Length - 1)
				{
					result += "\n"; 
				}
			}

			return result;
		}
		public static string Oper(Func<string, string> fct, string s)
		{
			return fct(s); 
		}
	}
}
//https://www.codewars.com/kata/56dbf59b0a10feb08c000227/train/csharp