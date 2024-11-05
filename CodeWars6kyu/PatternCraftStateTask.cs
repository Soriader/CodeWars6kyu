using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public interface IUnit
	{
		IUnitState State { get; set; }
		bool CanMove { get; }
		int Damage { get; }
	}

	public interface IUnitState
	{
		bool CanMove { get; }
		int Damage { get; }
	}

	public class SiegeState : IUnitState
	{
		public SiegeState()
		{
			CanMove = false;
			Damage = 20;
		}

		public bool CanMove { get; }
		public int Damage { get; }
	}

	public class TankState : IUnitState
	{
		public TankState()
		{
			CanMove = true;
			Damage = 5;
		}

		public bool CanMove { get; }
		public int Damage { get; }
	}

	public class Tank : IUnit
	{
		private IUnitState _state;

		public Tank()
		{
			State = new TankState();  
		}

		public IUnitState State
		{
			get => _state;
			set
			{
				_state = value;
			}
		}

		public bool CanMove => State.CanMove; 
		public int Damage => State.Damage;   
	}

}
//https://www.codewars.com/kata/5682e72eb7354b2f39000021/train/csharp