using DefiniraneNaKlasBankovaSmetka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaKlasChovekUpgraded
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter name of person: ");
            string name = Console.ReadLine();
            Console.Write("Enter age of person: ");
            int age = int.Parse(Console.ReadLine());
            Person person = new Person(name, age);
            BankAccount account = new BankAccount();
            Console.Write("Enter id: ");
            account.Id = int.Parse(Console.ReadLine());
            account.Deposit(500);
            account.WithDraw(100);
            person.Accounts.Add(account);
            Console.WriteLine($"Total balance for {person.Name}, with account id {account.Id} is {person.GetBalance()}$");          
        }
    }
}
