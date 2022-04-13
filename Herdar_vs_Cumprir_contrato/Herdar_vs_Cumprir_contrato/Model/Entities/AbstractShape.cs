using System;
using Herdar_vs_Cumprir_contrato.Model.Enums;
using System.Text;

namespace Herdar_vs_Cumprir_contrato.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
