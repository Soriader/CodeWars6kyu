using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class BrakingWellTask
	{
		public static double Dist(double v, double mu)
		{
			const double g = 9.81;
			double v_ms = v / 3.6;

			double d_reaction = v_ms * 1;

			double d_braking = (v_ms * v_ms) / (2 * mu * g);

			return d_reaction + d_braking;
		}
		public static double Speed(double d, double mu)
		{
			const double g = 9.81;
			double a = 1;
			double b = 2 * mu * g;
			double c = -2 * mu * g * d;

			double delta = b * b - 4 * a * c;

			if (delta < 0)
			{
				throw new ArgumentException("Delta jest ujemna, brak rzeczywistych rozwiązań.");
			}

			double v_ms = (-b + Math.Sqrt(delta)) / (2 * a);

			return v_ms * 3.6;
		}
	}
}
//https://www.codewars.com/kata/565c0fa6e3a7d39dee000125/train/csharp