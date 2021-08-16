using System;

namespace Exemplo_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua Matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
        }
    }
}

/* Fazer um progrma para ler um número interio N e uma matriz de ordem N contendo números inteiros. Em seguida,
 * mostrar a diagonal principal e a quantidade de valores negativos da matriz. ---  com o uso do Split ---*/