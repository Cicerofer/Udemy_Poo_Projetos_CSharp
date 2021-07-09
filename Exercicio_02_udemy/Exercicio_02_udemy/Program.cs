using System;
using System.Globalization;

namespace Exercicio_02_udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa? ");
            int nQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");

            string[] vect = Console.ReadLine().Split(' ');
            string lastName = vect[0];
            int age = int.Parse(vect[1]);
            double height = double.Parse(vect[2], CultureInfo.InvariantCulture);

            //Console.WriteLine(nomeCompleto);
            // Console.WriteLine(nQuartos);
            // Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            // Console.WriteLine(lastName);
            // Console.WriteLine(age);
            // Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
            global::System.Console.WriteLine("-----------------------------------");

            Console.WriteLine("Meu nome é "+nomeCompleto+", Minha casa tem "+nQuartos+" Quartos. Os Produstos que vendo custam R$ "+preco);
            global::System.Console.WriteLine("-----------------------------------");
            Console.WriteLine("Meu Sobrenome é "+lastName+", tenho "+age+" anos e tenho "+height+" de altura.");




            



        }
    }
}
