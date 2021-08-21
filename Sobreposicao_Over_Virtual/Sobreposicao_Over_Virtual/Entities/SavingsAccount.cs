using System;
using System.Collections.Generic;
using System.Text;

namespace Sobreposicao_Over_Virtual.Entities
{
    class SavingsAccount : Account
    {

        public double InterestRate { get; set; }// Taxa de juro

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance,double interestRate) : base (number, holder, balance)
        {
            InterestRate = interestRate;
        }


        public void UpdateBalance()// atualizar saldo
        {
            Balance += Balance * InterestRate;
        }

        public override void WthDraw(double amount)
        {
            Balance -= amount;
        }
    }
}
