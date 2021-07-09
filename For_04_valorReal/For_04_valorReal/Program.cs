using System;
using System.Globalization;

namespace For_04_valorReal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
            
        }
    }
    /* Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada de teste consiste de 3 valores reais,
     * cada um deles com uma casa decimal. Apresente a média ponderada para cada um testes conjuntos de 3 valores, sendo que
     *  o primeiro valor tem o peso 2, o segundo valor tem o peso 3 e o terceiro tem o peso 5.*/
}
