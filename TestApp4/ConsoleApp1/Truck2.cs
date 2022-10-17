using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Truck2 : Vehicle2
    {
        internal protected int Weels { get; private set; }
        internal protected Engine Truck2Engine { get; private set; }
        public Truck2(string model, int power, Engine engine, int weels = 24) : base(model, power)
        {
            Truck2Engine = engine;
            Weels = weels;
            WriteLine("+++ ctor Truck2 " + GetHashCode());
        }
        public override void Move()
        {
            WriteLine("Truck2 move: " + GetHashCode());
        }
        public override string ToString()
        {
            return $"Truck2 -> {base.ToString()}\b, weels:{Weels}, {Truck2Engine}.";
        }
    }
}
