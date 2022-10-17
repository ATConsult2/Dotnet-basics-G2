using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.getInstance();
            s1 = Singleton.getInstance();
            s1 = Singleton.getInstance();
            //----------------------------
            Vehicle v1 = new Vehicle(power: 122_000, model: "AA-1223");
            WriteLine(v1);
            WriteLine("Power: " + v1.Power); // internal protected!!
            //-----------------------------
            WriteLine(new String('-', 55));
            Car car = new Car("BMW", 200, new Engine(300,150,EngineType.Bensine));
            //WriteLine("Power: " + car.Power); // protected!!
            WriteLine("Engine Power: " + car.CarEngine.Power);
            WriteLine(car);
            //------------------------------

            WriteLine(new String('-', 11) + "Virtual Test" + new String('-', 11));
            Vehicle v2 = new Car("BMW", 250, new Engine(300, 150, EngineType.Bensine));
            v2.Move();

        }
    }
}
