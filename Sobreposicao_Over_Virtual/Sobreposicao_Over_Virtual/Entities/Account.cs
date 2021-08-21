using System;
using System.Collections.Generic;
using System.Text;

namespace Sobreposicao_Over_Virtual.Entities
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

        public virtual void WthDraw(double amount)// WthDraw= retirada, amount = quantia
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)// deposit= deposito, amount = quantia
        {
            Balance += amount;
        }

    }
}
