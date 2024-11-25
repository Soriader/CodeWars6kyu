using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class NCycleTask
	{
		public static int Running(int n)
		{
			if (GCD(n, 10) > 1)
			{
				return -1;

			}

			Dictionary<int, int> remainders = new Dictionary<int, int>();
			int remainder = 1;
			int position = 0;

			while (!remainders.ContainsKey(remainder))
			{
				remainders[remainder] = position; 
				remainder = (remainder * 10) % n; 
				position++;

				if (remainder == 0)
				{
					return 0;

				}
			}

			return position - remainders[remainder];
		}

		private static int GCD(int a, int b)
		{
			while (b != 0)
			{
				int temp = b;
				b = a % b;
				a = temp;
			}

			return a;
		}
	}
}
//https://www.codewars.com/kata/5a057ec846d843c81a0000ad/train/csharp