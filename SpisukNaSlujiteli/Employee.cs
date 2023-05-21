using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace SpisukNaSlujiteli
{
    internal class Employee
    {
        private string name;
        private int age;
        private double salary;
        private string email;
        private string position;
        private string department;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public Employee(string name, double salary, string position, string department, string email, int age)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = email;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"{this.name} {this.salary:F2} {this.email} {this.age}";
        }
    }
}
