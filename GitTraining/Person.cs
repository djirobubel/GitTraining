using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTraining
{
    internal class Person
    {
		private string _name;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}


		private string _surname;
		public string Surname
		{
			get { return _surname; }
			set { _surname = value; }
		}

		private int _age;
		public int Age
		{
			get { return _age; }
			set { _age = value; }
		}

		public Person(string name, string surname, int age)
		{
			Name = name;
			Surname = surname;
			Age = age;
		}

		public virtual void PrintInfo()
		{
			Console.WriteLine($"Name: {Name} ");
            Console.WriteLine($"Surname: {Surname} ");
            Console.WriteLine($"Age: {Age} ");
        }
	}

	internal class Military : Person
	{
		private string _rank;
		public string Rank
		{
			get { return _rank; }
			set { _rank = value; }
		}

		public Military(string name, string surname, int age, string rank) : base(name, surname, age)
		{
			Rank = rank;	
		}

	}
}
