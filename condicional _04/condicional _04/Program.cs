using System;

namespace condicional__04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qanto tempo durou esse jogo:");
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaFinal;
            }
            Console.WriteLine("O jogo durou " + duracao + " hora(s)");
        }
    }

    /* Leia a hora e a hora final de um jogo. A seguir calcule aduração do jogo,
     * sabendo que o mesmo pode começar em um dia e terminar em outro, tenho uma duração minima de 1 hora e máxima de 24 horas.*/
}
