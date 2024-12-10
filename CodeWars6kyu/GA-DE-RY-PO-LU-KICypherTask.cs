using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class GA_DE_RY_PO_LU_KICypherTask
	{
		public static string Encode(string str, string key)
		{
			Dictionary<char, char > code = new Dictionary<char, char>();

			for (int i = 0; i < key.Length; i += 2) 
			{
				if (i + 1 < key.Length) 
				{
					code[key[i]] = key[i + 1];
					code[key[i + 1]] = key[i];

					code[char.ToUpper(key[i])] = char.ToUpper(key[i + 1]);
					code[char.ToUpper(key[i + 1])] = char.ToUpper(key[i]);
				}
			}

			string result = "";

			foreach (char c in str) 
			{
				if (code.ContainsKey(c))
				{
					result += code[c];
				}
				else
				{
					result += c;
				}
			}

			return result;
		}

		public static string Decode(string str, string key)
		{
			Dictionary<char, char> decode = new Dictionary<char, char>();

			for (int i = 1; i < key.Length; i += 2)
			{
				if (i - 1 >= 0)
				{
					decode[key[i]] = key[i - 1];
					decode[key[i - 1]] = key[i];

					decode[char.ToUpper(key[i])] = char.ToUpper(key[i - 1]);
					decode[char.ToUpper(key[i - 1])] = char.ToUpper(key[i]);
				}
			}

			string result = "";

			foreach (char c in str)
			{
				if (decode.ContainsKey(c))
				{
					result += decode[c];
				}
				else
				{
					result += c;
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/592b7b16281da94068000107/train/csharp