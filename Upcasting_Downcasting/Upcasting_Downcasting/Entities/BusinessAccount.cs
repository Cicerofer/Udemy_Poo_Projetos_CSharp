using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; } // limite de empréstimo

        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
           if(amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
