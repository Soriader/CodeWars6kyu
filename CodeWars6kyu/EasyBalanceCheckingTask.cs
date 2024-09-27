using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class EasyBalanceCheckingTask
	{
		public static string Balance(string book)
		{
			var cleanBook = "";
			foreach (char c in book)
			{
				if (char.IsLetterOrDigit(c) || c == '.' || c == ' ' || c == '\n')
				{
					cleanBook += c;
				}
			}

			var partsOfBook = cleanBook.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			double totalExpense = 0;
			int transactionCount = 0;
			double originalBalance = 0;

			try
			{
				originalBalance = double.Parse(partsOfBook[0], System.Globalization.CultureInfo.InvariantCulture);
			}
			catch (FormatException)
			{
				throw new FormatException("Initial balance format is incorrect!");
			}

			double currentBalance = originalBalance;
			string result = $"Original Balance: {originalBalance.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}\n";

			for (int i = 1; i < partsOfBook.Length; i += 3)
			{
				string checkNumber = partsOfBook[i];
				string category = partsOfBook[i + 1];
				double expense = 0;

				try
				{
					expense = double.Parse(partsOfBook[i + 2], System.Globalization.CultureInfo.InvariantCulture);
				}
				catch (FormatException)
				{
					throw new FormatException($"Expense format is incorrect in check {checkNumber}.");
				}

				currentBalance -= expense;
				result += $"{checkNumber} {category} {expense.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)} Balance {currentBalance.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}\n";

				totalExpense += expense;
				transactionCount++;
			}

			double averageExpense = totalExpense / transactionCount;
			result += $"Total expense  {totalExpense.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}\n";
			result += $"Average expense  {averageExpense.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}";

			return result;

		}
	}
}
//https://www.codewars.com/kata/59d727d40e8c9dd2dd00009f/train/csharp