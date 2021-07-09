using System;

namespace Orientacao_Obejto_01
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());



            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine( "Pessoa mais velha: "+p1.Nome );
            }
            else
            {
                Console.WriteLine( "Pessoa mais velha: "+p2.Nome);
            }




        }
    }
    /*Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.*/
}
