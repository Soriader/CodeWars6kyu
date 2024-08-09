using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class SalesmanTravelTask
	{
		//Rozwiązanie z Git'a
		public static string Travel(string r, string zipcode)
		{
			List<string> Addresses = new List<string>(r.Split(','));
			List<string> Streets = new List<string>();
			List<string> HouseNums = new List<string>();

			if (!r.Contains(zipcode) || zipcode.Length < 7)
				return zipcode + ":/";

			if (zipcode.Length == 0)
				return ":/";

			foreach (string s in Addresses)
			{

				if (s.Contains(zipcode))
				{
					string HouseNum = s.Substring(0, 4);
					int HouseNumberLength = 0;

					foreach (char c in HouseNum)
					{
						if (char.IsDigit(c))
							HouseNumberLength++;
					}

					HouseNums.Add(s.Substring(0, HouseNumberLength));
					Streets.Add(s.Remove(s.IndexOf(zipcode)).Remove(0, HouseNumberLength).Trim());
				}
			}

			string StreetsS = string.Join(",", Streets.ToArray());
			string HouseNumSS = string.Join(",", HouseNums.ToArray());


			return zipcode + ":" + StreetsS + "/" + HouseNumSS;
		}


		//Moje rozwiązanie:


		//	public static string Travel(string r, string zipcode)
		//	{
		//		var addresses = r.Split(',');

		//		List<string> streets = new List<string>();
		//		List<string> numbers = new List<string>();

		//		foreach (var address in addresses)
		//		{
		//			if (address.Contains(zipcode))
		//			{
		//				string addressWithoutZip = address.Replace(zipcode, "").Trim();

		//				int spaceIndex = addressWithoutZip.IndexOf(' ');
		//				if (spaceIndex >= 0)
		//				{
		//					string number = addressWithoutZip.Substring(0, spaceIndex).Trim();
		//					string street = addressWithoutZip.Substring(spaceIndex).Trim();

		//					numbers.Add(number);
		//					streets.Add(street);
		//				}
		//			}
		//		}

		//		if (!streets.Any())
		//		{
		//			return $"{zipcode}/";
		//		}

		//		string streetPart = string.Join(",", streets);
		//		string numberPart = string.Join(",", numbers);

		//		return $"{zipcode}:{streetPart}/{numberPart}";
		//	}

		//}
	}
}
//https://www.codewars.com/kata/56af1a20509ce5b9b000001e/train/csharp