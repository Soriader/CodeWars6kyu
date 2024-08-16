using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CodeWars6kyu
{
	public class IPv4Toint32Task
	{
		public static uint ToInt32(string ip)
		{
			string[] segments = ip.Split('.');
			uint result = 0;

			for (int i = 0; i < segments.Length; i++)
			{
				uint segmentValue = uint.Parse(segments[i]);

				result = (result << 8) | segmentValue;
			}

			return result; 

		}
	}
}
//https://www.codewars.com/kata/52ea928a1ef5cfec800003ee/train/csharp