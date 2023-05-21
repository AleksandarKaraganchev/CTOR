using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobavqneNaMetodiKumBankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            BankAccount account = new BankAccount();
            account.Id = 1;
            account.Deposit(15);
            account.WithDraw(5);
            Console.WriteLine(account.ToString());
        }
    }
}
