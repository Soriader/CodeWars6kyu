using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class NewCashierDoesNotKnowTask
	{
		public static string GetOrder(string input)
		{        
			List<string> menuItems = new List<string>
		    {
			"burger", "fries", "chicken", "pizza", "sandwich", "onionrings", "milkshake", "coke"
		    };

			Dictionary<string, int> orderCount = new Dictionary<string, int>();
			foreach (var item in menuItems)
			{
				orderCount[item] = 0;
			}

			foreach (var item in menuItems)
			{
				int index = input.IndexOf(item);
				while (index != -1)
				{
					orderCount[item]++;
					input = input.Remove(index, item.Length);
					index = input.IndexOf(item);
				}
			}

			StringBuilder result = new StringBuilder();
			foreach (var item in menuItems)
			{
				for (int i = 0; i < orderCount[item]; i++)
				{
					result.Append(char.ToUpper(item[0]) + item.Substring(1) + " ");
				}
			}

			return result.ToString().TrimEnd();
		}
	}
}
//https://www.codewars.com/kata/5d23d89906f92a00267bb83d/train/csharp