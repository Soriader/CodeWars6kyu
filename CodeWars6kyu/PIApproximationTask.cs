using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class PIApproximationTask
	{
		public static ArrayList iterPi(double epsilon)
		{
			double sum = 0.0;
			int iterations = 0;
			double piApproximation = 0.0;

			while (true)
			{
				double term = Math.Pow(-1, iterations) / (2.0 * iterations + 1.0);
				sum += term;
				piApproximation = 4.0 * sum;

				if (Math.Abs(piApproximation - Math.PI) < epsilon)
				{
					break;
				}

				iterations++;
			}

			return new ArrayList { iterations + 1, Math.Round(piApproximation, 10) };
		}
	}
}
//https://www.codewars.com/kata/550527b108b86f700000073f/train/csharp