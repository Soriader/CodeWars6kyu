using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class KillerGarageDoorTask
	{
		public static string ProcessEvents(string events)
		{
			int position = 0;
			int direction = 1;
			bool moving = false;
			var result = new StringBuilder();

			foreach (char eventChar in events)
			{
				if (eventChar == 'P')
				{
					moving = !moving;
				}
				else if (eventChar == 'O')
				{
					direction *= -1;
					moving = true;
				}

				if (moving)
				{
					position += direction;
					if (position == 5 || position == 0)
					{
						moving = false;
						direction *= -1;
					}
				}

				result.Append(position);
			}

			return result.ToString();
		}

	}
}
//https://www.codewars.com/kata/58b1ae711fcffa34090000ea/train/csharp