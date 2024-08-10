using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeWars6kyu
{
	public class SumTheTreeTask
	{
		public int Value;
		public SumTheTreeTask Left;
		public SumTheTreeTask Right;

		public SumTheTreeTask(int value, SumTheTreeTask left = null, SumTheTreeTask right = null)
		{
			Value = value;
			Left = left;
			Right = right;
		}
		public static int SumTree(SumTheTreeTask root)
		{

			if (root == null)
			{
				return 0;

			}

			return root.Value + SumTree(root.Left) + SumTree(root.Right);

		}
	}
}
//https://www.codewars.com/kata/5800580f8f7ddaea13000025/train/csharp