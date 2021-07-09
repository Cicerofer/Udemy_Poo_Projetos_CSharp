using System;
using System.Globalization;

namespace condicional_06
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um valor para saber em qual intervalo você será direcionado:");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if(numero <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if(numero < 50.0)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if(numero <= 75.0)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo[75,100]");
            }
        }
    }

    /*Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
     seguintes intervalos([0,25], [25,50], [75,100]) este valor se encontra. Obviamente se o valor
    não estiver em nenhum destem intervalos, deverá ser impressa a mensagem "Fora de intervlo"*/
}
