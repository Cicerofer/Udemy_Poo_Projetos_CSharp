using System;

namespace For_08_Quadrado_Cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int n = int.Parse(Console.ReadLine());
          
            for (int i = 1; i <= n; i++)
            {

                int primeiro = i;
                int segundo = i * 1;
                int terceiro = i * 1 * 1;

                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
        }
    }
    /*Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, começando de 1 até N.
     * Para cada linha, mostrar o número de linha, depois o quadrado e o cubo do valor, conforme exemplo.*/
}
