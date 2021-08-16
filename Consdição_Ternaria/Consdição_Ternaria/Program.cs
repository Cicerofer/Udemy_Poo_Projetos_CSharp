using System;
using System.Globalization;

namespace Consdição_Ternaria
{
    class Program
    {
        static void Main(string[] args) 
        {

            Console.WriteLine("Digite um numero: " +
                "");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1: preco * 0.5;
            Console.WriteLine(desconto);   
        }
    }
}
/* Estrutura opcional ao if-else quando se deseja decidir um valor com base em uma condição
 * 
  -- ( condição ) ? valor_se_vedadeiro : Valor_se_falso;

     ( 2 > 4 ) ? 50 : 80 = 80;

      ( 10 != 3) ? "Maria" : "Alex" = "Maria";
*/