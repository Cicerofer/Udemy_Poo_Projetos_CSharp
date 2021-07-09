using System;

namespace While_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Informe o código do combustivel: ");

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if(tipo == 1)
                {
                    alcool = alcool + 1;
                }
                else if (tipo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3)
                {
                    diesel = diesel + 1;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito Obrigado");
            Console.WriteLine("Alcool: "+ alcool);
            Console.WriteLine("Gasolina: "+ gasolina);
            Console.WriteLine("Diesel: "+ diesel);
           
        }
    }
}
