using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Vehicle: object
    {
        public String Model { get; private set; }
        public int Power { get; private set; } // params

        public Vehicle(string model, int power)
        {
            Model = model;
            Power = power;
            WriteLine("+++ ctor Vehicle " + GetHashCode());
        }

        public override string ToString()
        {
            return $"Vehicle: Model \"{Model}\", Power -> {Power} ";
        }






    }

    internal class Car : Vehicle
    {
        public Car(string model, int power) : base(model, power)
        {
            WriteLine("+++ ctor Car " + GetHashCode());
        }
    }
}
