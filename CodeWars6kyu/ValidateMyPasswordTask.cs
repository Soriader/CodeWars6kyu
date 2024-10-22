using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class ValidateMyPasswordTask
	{
		public static string Validator(string password)
		{
			if (password.Length <= 3 || password.Length >= 20)
			{
				return "INVALID";
			}

			var isValid = true;
			var hasNumber = false;
			var hasLetter = false;

			for (int i = 0; i < password.Length; i++) 
			{
				if (!char.IsLetter(password[i]) && !char.IsDigit(password[i]))
				{
					isValid = false;
				}
				else if(char.IsLetter(password[i]))
				{
					hasLetter = true;
				}
				else if (char.IsDigit(password[i]))
				{
					hasNumber = true;

				}
			}

			if(isValid && hasNumber && hasLetter) 
			{
				return "VALID";
			}

			return "INVALID";
		}
	}
}
//https://www.codewars.com/kata/59c01248bf10a47bd1000046/train/csharp