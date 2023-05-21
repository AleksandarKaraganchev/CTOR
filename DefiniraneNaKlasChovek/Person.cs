using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaKlasChovek
{
    public class Person
    {
		private string name;
        private int age;
        public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public int Age
		{
			get { return age; }
			set { age = value; }
		}
		public void Print()
		{
			Console.WriteLine($"{this.Name} --> {this.Age}");
		}
        public Person()
        : this("No name", 1)
        {
        }
        public Person(int age)
            : this("No name", age)
        {
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
