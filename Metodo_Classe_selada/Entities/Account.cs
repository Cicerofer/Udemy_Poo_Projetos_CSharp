using System;
using System.Collections.Generic;
using System.Text;

namespace Metodo_Classe_selada.Entities
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

        public virtual void Wthdraw(double amount)// WthDraw= retirada, amount = quantia    // com o comando vitrual pode ser sobrescrito nas subclasses
        {
            Balance -= amount  + 5.0;
        }

        public void Deposit(double amount)// deposit= deposito, amount = quantia
        {
            Balance += amount;
        }

    }
}
