using System;
using System.Collections.Generic;
using System.Globalization;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionario #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Entre com  id do funcionário que terá aumento de salário");
            int procuraId = int.Parse(Console.ReadLine());

            Funcionario fun = list.Find(x => x.Id == procuraId);
            if(fun != null)
            {
                Console.Write("Entre com porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                fun.AumentoDeSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Este id não existe!");
            }
            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários: ");
            foreach(Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
