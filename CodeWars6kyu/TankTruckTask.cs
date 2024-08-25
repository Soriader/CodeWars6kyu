using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class TankTruckTask
	{
		public static int TankVol(int h, int d, int vt) 
		{
			double r = d / 2.0;

			double L = vt / (Math.PI * r * r);

			double theta = 2 * Math.Acos((r - h) / r);

			double segmentArea = 0.5 * r * r * (theta - Math.Sin(theta));

			double volume = segmentArea * L;

			return (int)Math.Floor(volume);
		}
		
	}
}
//https://www.codewars.com/kata/55f3da49e83ca1ddae0000ad/train/csharp