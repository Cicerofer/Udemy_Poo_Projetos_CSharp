using System;

namespace For_06_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i =1; i  <= n; i++)
            {
                fat = fat * 1;
            }

            Console.WriteLine("fat");
        }
    }

    /*Ler um valor N. Calcular e escrever seu respectivo fatorial.
     Fatorial de N = N * (N-1) * (N-2) * (N-3)*...*1. Lembrando que, por definição, fatorial de 01*/
}
