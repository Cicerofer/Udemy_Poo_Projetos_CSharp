using System;
using Classes_Abstratas.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Classes_Abstratas
    
{
    class Program
    {     
        
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();
            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));


            double sum = 0.0;
            foreach(Account acc in list)
            {
                sum += acc.Balance;
            }
            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach(Account acc in list)
            {
                Console.WriteLine("Update balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
        
    }
}        /*Se a classe Account não pode ser instanciada, por que simplesmente não criar somente SavingsAccount
            e BusinessAccount?

         Resposta:
           Reuso
           Polimorfismo: a superclasse classe genérica nos permite tratar de forma fácil e uniforme todos os tipos de conta,
           inclusive com polimorfismo se for o caso (como fizemos nos últimos exercícios). Por exemplo,
           você pode colocar todos tipos de contas em um a mesma coleção.

        Demo: suponha que você queria: 
        Totalizar o saldo de todas as contas.
        Sacar 10.00 de todas as contas.*/
