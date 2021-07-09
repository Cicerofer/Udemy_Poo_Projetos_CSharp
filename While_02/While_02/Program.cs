using System;

namespace While_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite sua Senha: ");
            int senha = int.Parse(Console.ReadLine()); 
            
            while (senha != 2002)            
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
