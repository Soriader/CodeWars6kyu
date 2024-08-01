using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class HelpTheBooksellerTask
	{
		public static string StockSummary(String[] lstOfArt, String[] lstOf1stLetter)
		{
			if (lstOfArt.Length == 0 || lstOf1stLetter.Length == 0)
			{
				return "";
			}

			Dictionary<string, int> stockList = new Dictionary<string, int>();

			foreach (var item in lstOfArt)
			{
				var check = item.Split(" ");
				var codeOfBook = check[0];
				var amountOfBook = check[1];

				var category = codeOfBook[0].ToString();

				if (!lstOf1stLetter.Contains(category))
				{
					continue;
				}

				if (!stockList.ContainsKey(category))
				{
					stockList[category] = 0;
				}
				stockList[category] += int.Parse(amountOfBook);
			}

			string result = "";

			foreach (var category in lstOf1stLetter)
			{
				int quantity = stockList.ContainsKey(category) ? stockList[category] : 0;
				result += $"({category} : {quantity}) - ";
			}

			return result.TrimEnd(' ', '-');
		}
	}
}
//https://www.codewars.com/kata/54dc6f5a224c26032800005c/train/csharp
