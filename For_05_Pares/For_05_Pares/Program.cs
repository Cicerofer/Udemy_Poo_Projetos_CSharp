using System;
using System.Globalization;

namespace For_05_Pares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite um numero: ");
                string[] line = Console.ReadLine().Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);
                


                if (y == 0)
                {
                    Console.WriteLine("Divisão impossivel");
                }
                else
                {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));

                    
                }
            }
        }
    }
    /* Fazer um programa par ler um número N. Depois leia N pares de números e mostre a divisão do primeiro
     * pelo segundo. Se o denominador for igual a zero, mostrar a mesagem "divisão impossivel".*/
}
