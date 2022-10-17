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
        internal protected int Power { get; private set; } // params

        public void Move() {
            WriteLine("Vehicle move: " + GetHashCode());
        
        }

        public Vehicle(string model, int power)
        {
            Model = model;
            Power = power;
            WriteLine("+++ ctor Vehicle " + GetHashCode());
        }

        public override string ToString()
        {
            return $"Vehicle: Model \"{Model}\", Power -> {Power}.";
        }
    }


    enum EngineType { 
     Bensine=1,
     Diesel=2,
     Gas=4,
     Electro=8,
     Hydrogene=16,
     Turbo=32
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

        public override string ToString()
        {
            return $"Engine: power->{Power}, mass->{Mass}, type->{EType.ToString()}";
        }
    }
    internal class Car : Vehicle
    {
        internal protected int Weels { get; private set; }
        internal protected Engine CarEngine { get; private set; }
        public Car(string model, int power, Engine engine, int weels = 4) : base(model, power)
        {
            CarEngine = engine;
            Weels = weels;
            WriteLine("+++ ctor Car " + GetHashCode());
        }
        public new void Move()
        {
            WriteLine("Car move: " + GetHashCode());
        }
        public override string ToString()
        {
            return $"Car -> {base.ToString()}\b, weels:{Weels}, {CarEngine}.";
        }
    }
}
