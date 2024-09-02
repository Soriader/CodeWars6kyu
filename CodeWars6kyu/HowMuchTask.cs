using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class HowMuchTask
	{
		public static string Howmuch(int m, int n)
		{
			List<string> results = new List<string>();

			int start = Math.Min(m, n);
			int end = Math.Max(m, n);

			for (int f = start; f <= end; f++)
			{
				if ((f - 1) % 9 == 0 && (f - 2) % 7 == 0)
				{
					int c = (f - 1) / 9;
					int b = (f - 2) / 7;
					results.Add($"[M: {f} B: {b} C: {c}]");
				}
			}

			return $"[{string.Join("", results)}]";
		}
	}
}
//https://www.codewars.com/kata/55b4d87a3766d9873a0000d4/train/csharp


//This idea is correct but is too long for execution 

//public static string Howmuch(int m, int n)
//{
//	if (n - m == 0)
//	{
//		return "[]";
//	}

//	List<int> valueF = new List<int>();
//	List<int> cForCar = new List<int>();
//	List<int> cForBoat = new List<int>();

//	int f = 1;
//	int cCar = 2;
//	int cBoat = 4;
//	bool check = true;
//	string result = "";

//	int resultCCar = 0;
//	int resultCBoat = 0;
//	int valueForCar = 0;
//	int valueForBoat = 1;

//	while (check)
//	{
//		if (f > n)
//		{
//			f = 1;
//			cBoat++;
//			cCar++;
//		}

//		if (f == 9 * cCar + 1)
//		{
//			valueForCar = f;
//			resultCCar = cCar;
//		}

//		if (f == 7 * cBoat + 2)
//		{
//			valueForBoat = f;
//			resultCBoat = cBoat;
//		}

//		f++;

//		if (valueForCar == valueForBoat)
//		{
//			valueF.Add(valueForCar);
//			cForCar.Add(resultCCar);
//			cForBoat.Add(resultCBoat);
//			valueForCar = 0;
//			resultCCar = 0;
//			resultCBoat = 0;
//			valueForBoat = 1;
//		}

//		if (cBoat >= n / 2)
//		{
//			check = false;
//		}
//	}

//	if (valueF.Count > 1)
//	{
//		result += "[";
//	}

//	for (int i = 0; i < valueF.Count; i++)
//	{
//		result += $"[M: {valueF[i]} B: {cForBoat[i]} C: {cForCar[i]}]";
//	}

//	if (valueF.Count > 1)
//	{
//		result += "]";
//	}

//	return result;
//}