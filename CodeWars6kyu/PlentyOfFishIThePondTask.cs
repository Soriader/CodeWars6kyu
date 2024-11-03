using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class PlentyOfFishIThePondTask
	{
		public int Fish(string shoal)
		{
			if (shoal == "")
			{
				return 1;
			}
			int lvl = 1;
			int eaten = 0;
			var charArr = shoal.ToCharArray();
			int[] arr = Array.ConvertAll(charArr, c => (int)Char.GetNumericValue(c));

			Array.Sort(arr);

			foreach (var fish in arr)
			{
				if (fish <= lvl)
				{
					eaten += fish;
				}

				if (eaten >= (lvl * 4))
				{
					eaten -= (lvl * 4);
					lvl += 1;
				}

			}

			return lvl;
		}
	}
}
//https://www.codewars.com/kata/5904be220881cb68be00007d/train/csharp