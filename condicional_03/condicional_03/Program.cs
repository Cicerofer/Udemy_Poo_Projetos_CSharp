using System;

namespace condicional_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digites dois numeros:");
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if(A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são Multiplos");
            }
        }
    }

    /* Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "São multiplos" ou "Não são multiplos
     * indicando se os valores lidos são múltiplos entre si. Ate~ção: os números devem poder ser digitados em ordem crescente ou decrecente."*/
}
