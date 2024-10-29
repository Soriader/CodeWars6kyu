using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class SheIsASmallWonderTask
	{
		private HashSet<string> knownWords = new HashSet<string>{
 "thank", "you", "for", "teaching", "me", "i", "already",
"know", "the", "word", "do", "not", "understand", "input"
 };
		public string LearnWord(string t)
		{
			if (!Regex.IsMatch(t, @"^[a-zA-Z]+$"))
			{
				return $"I do not understand the input";
			}
			if (knownWords.Contains(t.ToLower()))
			{
				return $"I already know the word {t}";
			}
			else
			{
				knownWords.Add(t.ToLower());
				return $"Thank you for teaching me {t}";
			}
		}
	}
	
}
//https://www.codewars.com/kata/56743fd3a12043ffbb000049/train/csharp