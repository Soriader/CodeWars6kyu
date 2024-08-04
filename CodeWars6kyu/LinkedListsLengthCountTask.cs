using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeWars6kyu
{
	public class LinkedListsLengthCountTask
	{
		public int Data;
		public LinkedListsLengthCountTask Next;

		public LinkedListsLengthCountTask(int data)
		{
			this.Data = data;
			this.Next = null;
		}

		public static int Length(LinkedListsLengthCountTask head)
		{
			int length = 0;
			LinkedListsLengthCountTask current = head;

			while (current != null)
			{
				length++;
				current = current.Next;
			}

			return length;
		}

		public static int Count(LinkedListsLengthCountTask head, Predicate<int> func)
		{
			int count = 0;
			LinkedListsLengthCountTask current = head;

			while (current != null)
			{
				if (func(current.Data))
				{
					count++;
				}
				current = current.Next;
			}

			return count;
		}

		public static LinkedListsLengthCountTask BuildOneTwoThree()
		{
			LinkedListsLengthCountTask first = new LinkedListsLengthCountTask(1);
			LinkedListsLengthCountTask second = new LinkedListsLengthCountTask(2);
			LinkedListsLengthCountTask third = new LinkedListsLengthCountTask(3);
			first.Next = second;
			second.Next = third;
			return first;
		}
	}
}
//https://www.codewars.com/kata/55beec7dd347078289000021/train/csharp