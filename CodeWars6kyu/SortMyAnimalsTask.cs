using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class Animal
	{
		public string Name { get; set; }
		public int NumberOfLegs { get; set; }
	}

	public class AnimalSorter
	{
		public List<Animal> Sort(List<Animal> input)
		{
			List<Animal> animals = new List<Animal>(input);

			animals = animals.OrderBy(x => x.NumberOfLegs).ThenBy(a => a.Name).ToList();

			return animals;
		}
	}
}
//https://www.codewars.com/kata/58ff1c8b13b001a5a50005b4/train/csharp