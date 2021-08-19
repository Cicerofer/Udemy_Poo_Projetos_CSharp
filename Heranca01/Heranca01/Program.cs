using System;
using Heranca01.Entities;

namespace Heranca01
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Jão", 100.0, 500.0);
            Console.WriteLine(account.Balance);


        }
    }
}
