using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);// total de elementos

            Console.WriteLine(mat.Rank);// quanto é a primeira dimensão da matriz- no caso a quantidade de linhas

            Console.WriteLine(mat.GetLength(0));// ela mostas a quantidade da primeira dimensão que são as linhas - 2

            Console.WriteLine(mat.GetLength(1));// ela mostra a segunda dimensão que é a quantidade de colunas - 3
        }
    }
}
/* A virgula entre couxetes mostra que você vai criar um arranjo "Bi direcional"vai ter linhas e colunas
 * - sendo antes da virgula as linhas e depois da virgula colunas*/