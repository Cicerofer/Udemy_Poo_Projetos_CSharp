using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public String Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void WthDraw(double amount)// WthDraw= retirada, amount = quantia
        {
            Balance -= amount;
        }

        public void Deposit(double amount)// deposit= deposito, amount = quantia
        {
            Balance += amount;
        }

    }
}
