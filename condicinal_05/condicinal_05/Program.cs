using System;
using System.Globalization;

namespace condicinal_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código do protudo, e depois a quantidade:");
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total;
            if(codigo == 1)
            {
                total = quantidade * 4.0;
            }
            else if(codigo == 2)
            {
                total = quantidade * 4.5;
            }
            else if(codigo == 3)
            {
                total = quantidade * 5.0;
            }
            else if(codigo == 4)
            {
                total = quantidade * 2.0;
            }
            else
            {
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    /*Com base na tabela abaixo, escreva um progrma que leia o código de um item e a quantidade deste item.
     * A seguir, calcule e mostre o valor da conta a pagar.*/
}
