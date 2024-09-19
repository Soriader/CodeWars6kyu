using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class CalculateTheAreaOfARegularSidesPolygonInsideTask
	{
		public static double AreaOfPolygonInsideCircle(double circleRadius, int numberOfSides)
		{
			double angle = (2 * Math.PI) / numberOfSides;
			double area = 0.5 * numberOfSides * Math.Pow(circleRadius, 2) * Math.Sin(angle);

			return Math.Round(area, 3);
		}
	}
}
//https://www.codewars.com/kata/5a58ca28e626c55ae000018a/train/csharp