using System;
using System.Globalization;

namespace Vetor01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de posições de seu arrey: ");

            int n  =  int.Parse(Console.ReadLine());
            Console.WriteLine("digite a Altura: ");
            double[] vect = new double[n];

            for(int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double media = sum / n;

            Console.WriteLine( "Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture)); 
        }
    }

    /* Fazer um programa para ler um número inteiro N e a altura de N pessoas.
     * Armazena as N alturas em um vetor. Em seguida, mostras a altura média dessas pessoas.*/
}
