using System;

namespace Exemplo2_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(mat[i, j] == x)
                    {
                        Console.WriteLine("Posição " + i + "," + j + ":");
                        if(j > 0)
                        {
                            Console.WriteLine("Esquerda: "+ mat[i, j - 1]);
                        }
                        if(i > 0)
                        {
                            Console.WriteLine("Acima: "+ mat[i - 1, j]);
                        }
                        if(j < n - 1)
                        {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }
                        if(i < m - 1)
                        {
                            Console.WriteLine("Abaixo: "+ mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
/* Fazer um programa para ler dois números inteiros M e N, e depois ler uma matriz de M linhas por N colunas contendo números inteiros,
 podendo haver repetições. Em seguida, ler um número inteiro X que pertece á matriz. Para cada ocorrência de X,
 mostar os valores á esquerda, acima, á dieita e abaixo de X, quando houver, conforme exemplo.*/
