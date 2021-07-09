using System;

namespace condicional_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int n = int.Parse(Console.ReadLine());


            if(n % 2 == 0)
            {
                Console.WriteLine("Esse numero é PAR");
            }
            else
            {
                Console.WriteLine("Esse numero é IMPAR");
            }
        }
    }
    /* Fazer um progrma para ler um número inteiro e dizer se esse número é par ou impar*/
}
