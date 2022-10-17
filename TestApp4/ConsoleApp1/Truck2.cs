using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Car2 : Vehicle2
    {
        internal protected int Weels { get; private set; }
        internal protected Engine Car2Engine { get; private set; }
        public Car2(string model, int power, Engine engine, int weels = 4) : base(model, power)
        {
            Car2Engine = engine;
            Weels = weels;
            WriteLine("+++ ctor Car2 " + GetHashCode());
        }
        public override void Move()
        {
            WriteLine("Car2 move: " + GetHashCode());
        }
        public override string ToString()
        {
            return $"Car2 -> {base.ToString()}\b, weels:{Weels}, {Car2Engine}.";
        }
    }
}
