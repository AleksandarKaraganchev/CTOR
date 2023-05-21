using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaKlasBankovaSmetka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Enter number of bank accounts: ");
            int n = int.Parse(Console.ReadLine());
            BankAccount bankAccount = new BankAccount();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter account id: ");
                bankAccount.Id = int.Parse(Console.ReadLine());
                Console.Write("Enter account balance: ");
                bankAccount.Balance = double.Parse(Console.ReadLine());
                bankAccount.Print();
            }
        }
    }
}
