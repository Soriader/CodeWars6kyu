using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class DiseaseSpreadTask
	{
		public static int Epidemic(int tm, int n, int s0, int i0, double b, double a)
		{
			double dt = (double)tm / n;

			double S = s0;  
			double I = i0;  
			double R = 0;  

			double maxInfected = I;

			for (int k = 0; k < n; k++)
			{
				double newS = S - dt * b * S * I;
				double newI = I + dt * (b * S * I - a * I);
				double newR = R + dt * a * I;

				S = newS;
				I = newI;
				R = newR;

				if (I > maxInfected)
				{
					maxInfected = I;
				}
			}

			return (int)maxInfected;
		}

	}
}
//https://www.codewars.com/kata/566543703c72200f0b0000c9/train/csharp