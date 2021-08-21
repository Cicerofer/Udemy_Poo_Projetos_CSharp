using System;
using Sobreposicao_Over_Virtual.Entities;


namespace Sobreposicao_Over_V
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.WthDraw(10.0);
            acc2.WthDraw(10.0);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
;        }
    }
}
