using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public interface iUnit
	{
		int Position { get; set; }
		void Move();
		IMoveBehavior MoveBehavior { get; set; }
	}

	public interface IMoveBehavior
	{
		void Move(iUnit unit);
	}

	public class Fly : IMoveBehavior
	{
		public void Move(iUnit unit)
		{
			unit.Position += 10; 
		}
	}

	public class Walk : IMoveBehavior
	{
		public void Move(iUnit unit)
		{
			unit.Position += 1;

		}
	}

	public class Viking : iUnit
	{
		public Viking()
		{
			MoveBehavior = new Walk();
			Position = 0;
		}

		public IMoveBehavior MoveBehavior { get; set; }

		public int Position { get; set; }

		public void Move()
		{
			MoveBehavior.Move(this);
		}
	}
}
//https://www.codewars.com/kata/5682e809386707366d000024/train/csharp