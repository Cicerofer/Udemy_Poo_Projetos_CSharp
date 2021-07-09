using System;

namespace For_03_intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    cont_in = cont_in + 1;
                }
                else
                {
                    cont_out = cont_out + 1;
                }
            }

            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");
        }
    }
    /* Leia um valor inteiro N. Este valor será a quantidade de valores inteiro X que são lidos em seguida. Mostre quantos destes valores X estão dentro do intervalo
      [10,20] e quantos estão fora do intervalo, mostrando essas informaç~es conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).*/
}
