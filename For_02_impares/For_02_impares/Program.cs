using System;

namespace For_02_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int x = int.Parse(Console.ReadLine());

            for(int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    /*Leia um valor inteiro X ( 1 <=X <= 1000). Em seguida mostre os impares de 1 até X, um valor por linha, inclusive o X, se for o caso.*/
}
