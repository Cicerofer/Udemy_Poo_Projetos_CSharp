using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_01.Entities
{
    class Vehicle
    {
        public string Model { get; set; }

        public Vehicle(string model)
        {
            Model = model;
        }
    }
}
