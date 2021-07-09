using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green";



            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            */


            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            // PLACEHOLDERS
            Console.WriteLine("{0} tem  {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            //INTERPOLAÇÃO
            Console.WriteLine($"{nome} tem {idade} anos e tem sado igual a {saldo:F2} reais");

            //CONCATENAÇÃO
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " +saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais " );
        }
    }
}
