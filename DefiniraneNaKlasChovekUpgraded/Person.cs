using DefiniraneNaKlasBankovaSmetka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaKlasChovekUpgraded
{
    internal class Person
    {
		private string name;
        private int age;
        private List<BankAccount> accounts = new List<BankAccount>();
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
		public List<BankAccount> Accounts
		{
            get { return accounts; }
            set { accounts = value; }
        }
		public Person(string name, int age)
		{
			this.name = name;
			this.age = age;
            this.Accounts = new List<BankAccount>();
        }
		public Person(string name, int age,List<BankAccount> accounts)
		{
            this.name = name;
            this.age = age;
			this.accounts = accounts;
        }
		public double GetBalance()
		{
			return this.accounts.Sum(x => x.Balance);
		}
	}
}
