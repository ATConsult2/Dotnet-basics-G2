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
            Vehicle2 v22 = new Car2("BMW", 250, new Engine(300, 150, EngineType.Bensine));
            v22.Move();

            Object o = new Car("Audi", 250, new Engine(300, 250, EngineType.Bensine));
            Car2 car3 = (Car2)o;

            //1 met, as operator
            Car2 car33 = o as Car2;
            //if (car33 != null) car33.Move();
            car33?.Move();

            //2 met, is operator
            if (o is Car car44) car44.Move();

            // 
            WriteLine(new String('-', 11) + "Polimotf Test" + new String('-', 11));
            testVehicle(new Car2("BMW", 250, new Engine(300, 150, EngineType.Bensine)));
            testVehicle(new Truck2("BMW", 600, new Engine(600, 600, EngineType.Diesel)));




        }

        // static void testVehicle(Vehicle2 v2)
        static void testVehicle(IMovable v2)
        {
            //.....
            v2.Move();
           // v2.Move(10);
           // v2.Rotate();
        }
    }
}
