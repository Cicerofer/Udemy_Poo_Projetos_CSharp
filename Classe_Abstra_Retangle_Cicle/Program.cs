
using System;
using System.Collections.Generic;
using Classe_Abstra_Retangle_Cicle.Entities;
using Classe_Abstra_Retangle_Cicle.Entities.Enums;
using System.Globalization;


namespace Classe_Abstra_Retangle_Cicle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }

                    Console.WriteLine();
                    Console.WriteLine("SHAPE AREAS:");
                foreach (Shape shape in list)
                {
                     Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
                }
        }
    }
}

/*São métodos Abstrados
    *São métodos que não possuem implementação.
    *Métodos precisam ser abstratos quando a classe é genérica demais para conter sua implementação.
    *Se uma clsse possuir pelo menos um método abstrato, então esta classe também é abstrata.
    *
    *
    *Exercicio:
    *Fazer um programa para ler os dados de N figuras (N foenecido pelo usuário), 
    *e deposi mostras as áreas destas figuras na mesma ordem em que foram digitadas.
 */
