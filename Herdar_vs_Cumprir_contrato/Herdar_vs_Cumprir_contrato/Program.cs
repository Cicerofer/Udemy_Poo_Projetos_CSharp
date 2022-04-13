using System;
using Herdar_vs_Cumprir_contrato.Model.Entities;
using Herdar_vs_Cumprir_contrato.Model.Enums;

namespace Herdar_vs_Cumprir_contrato
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.black };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
