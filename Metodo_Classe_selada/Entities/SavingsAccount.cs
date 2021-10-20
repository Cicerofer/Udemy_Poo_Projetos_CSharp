using System;
using System.Collections.Generic;
using System.Text;

namespace Metodo_Classe_selada.Entities
{
     class SavingsAccount : Account  // Erda tudo que a classe Account tem
    {

        public double InterestRate { get; set; }// Taxa de juro

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }


        public void UpdateBalance()// atualizar saldo
        {
            Balance += Balance * InterestRate;
        }

        public  sealed override void Wthdraw(double amount)
        {
            base.Wthdraw(amount);
            Balance -= 2.0;
        }
    }
}
