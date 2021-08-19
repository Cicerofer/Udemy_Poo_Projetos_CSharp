using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca01.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance) // numero, titular, saldo
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void WithDraw(double amount) // saque
        {
            Balance -= amount; 
        }
        public void Deposit(double amount) //deposito
        {
            Balance += amount;
        }
    }
}
