using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting.Entities
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
    }
}
