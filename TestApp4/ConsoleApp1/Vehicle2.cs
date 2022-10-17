using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Vehicle2 : object
    {
        protected String Model { get; private set; }
        internal protected int Power { get; private set; } // params

        public virtual void Move()
        {
            WriteLine("Vehicle2 move: " + GetHashCode());

        }

        public Vehicle2(string model, int power)
        {
            Model = model;
            Power = power;
            WriteLine("+++ ctor Vehicle2 " + GetHashCode());
        }

        public override string ToString()
        {
            return $"Vehicle2: Model \"{Model}\", Power -> {Power}.";
        }
    }


}
