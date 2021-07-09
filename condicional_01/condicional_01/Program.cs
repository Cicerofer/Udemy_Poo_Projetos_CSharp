using System;

namespace condicional_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if(n < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("POSITIVO");
            }
        }
    }

    /* Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não
     = Entrada: -10   Saida: Negativo
     = Entrada: 8     Saida: Positivo
     = Entrada: 0     Saida: Positivo  */
}
