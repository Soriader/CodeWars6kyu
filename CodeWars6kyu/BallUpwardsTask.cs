using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class BallUpwardsTask
	{
		public static int MaxBall(int v0)
		{
			double velocity = v0 / 3.6;
			double g = 9.81;

			double timeInSeconds = velocity / g;

			int timeInTenths = (int)Math.Round(timeInSeconds * 10);

			return timeInTenths;
		}
	}
}
//https://www.codewars.com/kata/566be96bb3174e155300001b/train/csharp