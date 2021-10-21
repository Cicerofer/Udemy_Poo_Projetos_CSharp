﻿using Classe_Abstra_Retangle_Cicle.Entities.Enums;


namespace Classe_Abstra_Retangle_Cicle.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
