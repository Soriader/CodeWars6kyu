using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CodeWars6kyu
{
	public class AlternatingSplitTask
	{
		public static string Encrypt(string text, int n)
		{
			if (n <= 0 || string.IsNullOrEmpty(text))
			{
				return text;
			}

			int iterator = 0;
			string encryptText = text;

			while (iterator < n) 
			{
				string odd = "";
				string even = "";

				for (int i = 0; i < encryptText.Length; i++) 
				{
					if(i % 2 != 0)
					{
						odd += encryptText[i];
					}
					else if(i % 2 == 0)
					{
						even += encryptText[i];
					}
				}

				encryptText = odd + even;
				iterator++;

			}

			return encryptText;
		}

		public static string Decrypt(string encryptedText, int n)
		{
			if (n <= 0 || string.IsNullOrEmpty(encryptedText))
			{
				return encryptedText;
			}

			string decryptText = encryptedText;

			for (int iterator = 0; iterator < n; iterator++)
			{
				int halfLength = decryptText.Length / 2;
				string odd = decryptText.Substring(0, halfLength); 
				string even = decryptText.Substring(halfLength); 

				decryptText = "";

				for (int i = 0; i < even.Length; i++)
				{
					decryptText += even[i]; 
					if (i < odd.Length) 
					{
						decryptText += odd[i];
					}
				}
			}

			return decryptText;
		}
	}
}
//https://www.codewars.com/kata/57814d79a56c88e3e0000786/train/csharp