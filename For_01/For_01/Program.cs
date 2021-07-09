using System;

namespace For_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos numeros inteiro você vai digitar? ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("Soma = "+ soma);
        }
    }

    /*                               Exemplo de uma estrutura Repetitiva PARA
     * Aoiniciar o programa coloque a quantidade de vezes que quer executar, coloque os valores e veja o resultado*/
}
