﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobavqneNaMetodiKumBankAccount
{
    internal class BankAccount
    {
        private int id;
        private double balance;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public override string ToString()
        {
            return $"Account with id |{this.Id}|,has  balance |{this.Balance}|$";
        }
        public void Deposit(double amount)
        {
            this.balance += amount;
        }
        public void WithDraw(double amount)
        {
            this.balance -= amount;
        }
    }
}
