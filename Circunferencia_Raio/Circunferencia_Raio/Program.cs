using System;
using System.Globalization;

namespace Circunferencia_Raio
{
    class Program
    {

        

        static void Main(string[] args)
        {

            
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circuferência: "+ circ.ToString("F2", CultureInfo.InvariantCulture) );
            Console.WriteLine("Volume: "+ volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        
    }

    /*Fazer um programa para ler um valor numérico qualquer, e daí mostrar quanto seria o valor
     * de uma circunfêrencia e do volume de uma esfera para um raio daquele valor. Informar também 
     * o valor de PI com duas casas decimais.*/
}
