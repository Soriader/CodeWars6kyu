using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class Fraction
	{
		private long Top { get; set; }
		private long Bottom { get; set; }

		public Fraction(long numerator, long denominator)
		{
			Top = numerator;
			Bottom = denominator;
			Simplify();
		}

		// Equality checking
		public override int GetHashCode() => this.GetHashCode(); // not actually used
		public override bool Equals(object o) => Compare(this, o as Fraction) == 0;
		public static bool operator ==(Fraction f1, Fraction f2) => Compare(f1, f2) == 0;
		public static bool operator !=(Fraction f1, Fraction f2) => Compare(f1, f2) != 0;
		private static long Compare(Fraction f1, Fraction f2) => f1.Top * f2.Bottom - f2.Top * f1.Bottom;

		private void Simplify()
		{
			long gcd = GCD(Math.Abs(Top), Math.Abs(Bottom));
			Top /= gcd;
			Bottom /= gcd;

			if (Bottom < 0)
			{
				Top = -Top;
				Bottom = -Bottom;
			}
		}

		private long GCD(long a, long b)
		{
			while (b != 0)
			{
				long temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}

		public override string ToString()
		{
			return $"{Top}/{Bottom}";
		}

		public static Fraction operator +(Fraction f1, Fraction f2)
		{
			long numerator = f1.Top * f2.Bottom + f2.Top * f1.Bottom;
			long denominator = f1.Bottom * f2.Bottom;
			return new Fraction(numerator, denominator); 
		}

	}
}
//https://www.codewars.com/kata/572bbd7c72a38bd878000a73/train/csharp