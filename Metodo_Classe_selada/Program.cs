﻿using System;
using Metodo_Classe_selada.Entities;

namespace Metodo_Classe_selada
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account (1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount (1002, "Anna", 500.0, 0.01);


            acc1.Wthdraw(10.0);
            acc2.Wthdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);



        }
    }
}


