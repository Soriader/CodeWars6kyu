using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class GroupIn10sTask
	{
		public static int[][] GroupIn10s(int[] array)
		{
			if (array == null || array.Length == 0)
			{
				return Array.Empty<int[]>();
			}

			Array.Sort(array);

			int maxGroup = array.Max() / 10;

			var grouped = new List<int[]>();

			for (int i = 0; i <= maxGroup; i++)
			{
				var group = array.Where(num => num / 10 == i).ToArray();

				grouped.Add(group.Length > 0 ? group : null);
			}

			return grouped.ToArray();
		}
	}
}
//https://www.codewars.com/kata/5694d22eb15d78fe8d00003a/train/csharp