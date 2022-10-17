using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Vehicle : object
    {
        protected String Model { get; private set; }
        protected int Power { get; private set; } // params

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


    enum EngineType { 
     Bensine,
     Diesel,
     Gas
    }
    internal class Engine { 
      public int Mass { get; private set; }
      public int Power { get; private set; }
      public EngineType EType { get; private set; }

      public Engine(int mass, int power, EngineType eType)
        {
            Mass = mass;
            Power = power;
            EType = eType;
        }   
    }
    internal class Car : Vehicle
    {
        public int Weels { get; private set; }
        public Engine CarEngine { get; private set; }
        public Car(string model, int power, Engine engine, int weels = 4) : base(model, power)
        {
            CarEngine = engine;
            Weels = weels;
            WriteLine("+++ ctor Car " + GetHashCode());
        }
    }
}
