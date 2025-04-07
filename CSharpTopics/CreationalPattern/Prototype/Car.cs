using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Prototype
{
    public class Car
    {
        public string Model { get; set; }
        public string Name { get; set; }
        public double Fuel { get; set; }

        public Car Copy() { 
            return new Car { Fuel = Fuel, Name = Name };
        }
    }
}
