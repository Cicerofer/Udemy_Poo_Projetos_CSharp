using System;
using System.Globalization;

namespace Vetor_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos produtos: ");

            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];


            Console.WriteLine("Digite nome e valor de produtos: ");
            for (int i = 0; i  < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double media = sum / n;
            Console.WriteLine("Preço média = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    /* Fazer um programa para ler um número inteiro N e os dados ( nome e preço) de N Produtos.
     * Armazene os N produtos em um vetor. Em seguida, mostrar o preço médio dos produtos*/
}
