using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public partial class Node
	{
		public int Data;
		public Node Next;

		public Node(int data)
		{
			this.Data = data;
			this.Next = null;
		}

		public static Node InsertNth(Node head, int index, int data)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException();

			}

			Node newNode = new Node(data);

			if (index == 0)
			{
				newNode.Next = head;
				return newNode;
			}

			Node current = head;
			int count = 0;

			while (current != null && count < index - 1)
			{
				current = current.Next;
				count++;
			}

			if (current == null)
			{
				throw new ArgumentOutOfRangeException();
			}

			newNode.Next = current.Next;
			current.Next = newNode;

			return head;
		}
	}
}
//https://www.codewars.com/kata/55cacc3039607536c6000081/train/csharp