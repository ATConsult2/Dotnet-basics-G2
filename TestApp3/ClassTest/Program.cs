
using andestech.learning2022.krasn.geer;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car0;
            Car car = new Car();
            //1
            car.Power = 200;
            car.Mass = 1500;
            car.Vendor = "GAZ";
            WriteLine(car.getInfo());
            //2
            Car car2 = new Car{ Vendor = "Vaz", Power = 120, Mass = 1200 };
            WriteLine(car2.getInfo());

            //---------------
            Car2 car22 = new Car2 { Vendor = "BMW", Power = 240, Mass = 1700 };
            WriteLine(car22.getInfo());

            //----------------
            Car3 car33 = new Car3("UAZ",120,1800);
            WriteLine(car33.getInfo());

            //car33.Power = 111;

            new Car();

        }
    }
}
