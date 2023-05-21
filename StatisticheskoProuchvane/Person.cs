using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticheskoProuchvane
{
    internal class Person
    {
		private int age;
        private string name;
        public int Age
		{
			get { return age; }
			set { age = value; }
		}
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public Person(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}
	}
}
